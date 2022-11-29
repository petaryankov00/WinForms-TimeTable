using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.Config;

namespace TimeTable.Projects
{
    public partial class ProjectViewForm : Form
    {
        private SQLConfig config;
        private bool isReadyForUpdate = false;
        private decimal currentProjectId;
        public ProjectViewForm()
        {
            config = new SQLConfig();
            InitializeComponent();
        }

        private void ProjectViewForm_Load(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
            this.EditButton.Enabled = false;
            this.ReportMonthButton.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT PROJECT_ID as ID,PROJECT_NAME as NAME, PROJECT_BEGIN as [Begin], PROJECT_END as [End],PROJECT_DESCRIPTION as [Description],PROJECT_STATUS as [Status],PROJECT_MAXHOURS as [Max hours] FROM PROJECT WHERE PROJECT_NAME LIKE '%"
                + SearchBox.Text + "%' OR PROJECT_DESCRIPTION LIKE '%" + SearchBox.Text + "%' OR PROJECT_STATUS LIKE '%" + SearchBox.Text + "%'";

            config.Load_DTG(sql, AllProjectsGridView);
        }

        private void AllEmployeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.AllProjectsGridView.Rows[e.RowIndex];
                this.currentProjectId = (decimal)row.Cells["ID"].Value;
                ProjectNameTextBox.Text = row.Cells["Name"].Value.ToString();
                StartDatePicker.Text = row.Cells["Begin"].Value.ToString();
                EndDatePicker.Text = row.Cells["End"].Value.ToString();
                DescriptionTextBox.Text = row.Cells["Description"].Value.ToString();
                WorkHoursDropdown.Text = row.Cells["Max Hours"].Value.ToString();
                StatusBox.Text = row.Cells["Status"].Value.ToString();
                this.ReportMonthPicker.MinDate = DateTime.Parse(row.Cells["Begin"].Value.ToString());
                this.ReportMonthPicker.MaxDate = DateTime.Parse(row.Cells["End"].Value.ToString());
                this.ReportMonthPicker.Value = DateTime.Parse(row.Cells["Begin"].Value.ToString());


                string query = $"SELECT pm.PROJECT_MONTH as [Month],SUM(PROJECT_HOURS) as [Reported Hours] ,COUNT(ph.EMPLOYEE_ID) as [Employee Count] FROM PROJECT_HOURS as ph JOIN PROJECT_MONTHS as pm ON ph.PROJECT_MONTH_ID = pm.PROJECT_MONTH_ID " +
                    $"WHERE ph.PROJECT_ID = {this.currentProjectId} GROUP BY pm.PROJECT_MONTH";

                config.Load_DTG(query, this.WorkedHoursGridView);

                if (row.Cells["Status"].Value.ToString() == "O")
                {
                    this.EditButton.Enabled = true;
                    this.ReportMonthButton.Enabled = true;
                    this.isReadyForUpdate = true;
                }
                else 
                {
                    this.EditButton.Enabled = false;
                    this.ReportMonthButton.Enabled = false;
                    this.isReadyForUpdate = false;
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.isReadyForUpdate)
            {
                if (String.IsNullOrEmpty(ProjectNameTextBox.Text) ||
                 String.IsNullOrEmpty(DescriptionTextBox.Text) ||
                 String.IsNullOrEmpty(WorkHoursDropdown.Text)
                 || String.IsNullOrEmpty(StatusBox.Text))
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = $"UPDATE PROJECT SET PROJECT_NAME = '{ProjectNameTextBox.Text}', PROJECT_BEGIN = '{StartDatePicker.Text}', PROJECT_END = '{EndDatePicker.Text}', PROJECT_DESCRIPTION = '{DescriptionTextBox.Text}'," +
                                     $" PROJECT_MAXHOURS = {WorkHoursDropdown.Text}, PROJECT_STATUS = '{StatusBox.Text}' WHERE PROJECT_ID = {this.currentProjectId}";

                if (this.StatusBox.Text == "C")
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to close this project?", "Warning", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.No)
                    {
                        return;
                      
                    }
                }

                if (config.Execute_CUD(query))
                {
                    MessageBox.Show("Project inforamtion updated");
                    this.SearchButton_Click(sender, e);
                    this.CancelButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Unable to update project. Please contact administrator");
                }

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProjectNameTextBox.Text = "";
            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
            DescriptionTextBox.Text = "";
            WorkHoursDropdown.SelectedItem = null;
            StatusBox.SelectedItem = null;
            ReportMonthPicker.Text = null;
            this.EditButton.Enabled = false;
            this.ReportMonthButton.Enabled = false;
            this.isReadyForUpdate = false;
        }

        private void ReportMonthButton_Click(object sender, EventArgs e)
        {
            if (this.isReadyForUpdate)
            {
                if (ReportMonthPicker.Value.Month == DateTime.Now.Month || (ReportMonthPicker.Value.Month > DateTime.Now.Month && ReportMonthPicker.Value.Year == DateTime.Now.Year) || ReportMonthPicker.Value.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("You can't report month, because it is not finished.");
                    return;
                }

                string checkStatusQuery = $"SELECT PROJECT_MONTH_STATUS FROM PROJECT_MONTHS WHERE PROJECT_ID = {this.currentProjectId} AND PROJECT_YEAR = {ReportMonthPicker.Value.Year} AND PROJECT_MONTH = {ReportMonthPicker.Value.Month}";

                var status = config.GetSingleValue(checkStatusQuery) as string;

                if (status == null)
                {
                    MessageBox.Show("Unable to report month. Please contact administrator");
                    return;
                }
                else if (status == "C")
                {
                    MessageBox.Show("Selected month has already been reported.");
                    return;
                }

                string query = $"UPDATE PROJECT_MONTHS SET PROJECT_MONTH_STATUS = 'C' WHERE PROJECT_ID = {this.currentProjectId} AND PROJECT_YEAR = {ReportMonthPicker.Value.Year} AND PROJECT_MONTH = {ReportMonthPicker.Value.Month}";

                if (config.Execute_CUD(query))
                {
                    MessageBox.Show("Successfully reported month");
                }
                else
                {
                    MessageBox.Show("Unable to report month. Please contact administrator");
                }
            }
        }
    }
}
