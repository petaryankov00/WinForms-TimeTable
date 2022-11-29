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

namespace TimeTable.Employees
{
    public partial class AddWorkedTimeForm : Form
    {
        private SQLConfig config;
        private decimal employeeId;
        private decimal projectId;
        private decimal currentMaxHours; 
        private bool isSelectedRow = false;

        public AddWorkedTimeForm(decimal employeeId)
        {
            InitializeComponent();
            config = new SQLConfig();
            this.employeeId = employeeId;
        }

        private void AddWorkedTimeForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT PROJECT_ID as ID, PROJECT_NAME as Name, PROJECT_BEGIN as [Begin], PROJECT_END as [End], PROJECT_STATUS as Status, PROJECT_MAXHOURS as [Max hours] FROM Project WHERE PROJECT_STATUS = 'O'";

            config.Load_DTG(sql, ProjectsGridView);
        }

        private void ProjectsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.ProjectsGridView.Rows[e.RowIndex];
                this.projectId = (decimal)row.Cells["ID"].Value;
                this.currentMaxHours = (decimal)row.Cells["Max Hours"].Value;
                ProjectNameTextBox.Text = row.Cells["Name"].Value.ToString();
                DateOfWorkedHoursPicker.MinDate = (DateTime)row.Cells["Begin"].Value;
                DateOfWorkedHoursPicker.MaxDate = (DateTime)row.Cells["End"].Value;
                this.isSelectedRow = true;
            }
        }

        private void AddHoursButton_Click(object sender, EventArgs e)
        {
            if (this.isSelectedRow)
            {
                if (String.IsNullOrEmpty(DescriptionTextBox.Text))
                {
                    MessageBox.Show($"Description field is required");
                    return;
                }

                if (DateOfWorkedHoursPicker.Value > DateTime.Now)
                {
                    MessageBox.Show($"You cannot report worked time in future.");
                    return;
                }

                if (String.IsNullOrEmpty(MaxHours.Text) || this.currentMaxHours < int.Parse(MaxHours.Text))
                {
                    MessageBox.Show($"Working hours must be between 1 and {this.currentMaxHours} for this project");
                    return;
                }
                string getProjectMonthIdQuery = "SELECT PROJECT_MONTH_ID FROM PROJECT_MONTHS WHERE PROJECT_ID = " + this.projectId +
                " AND PROJECT_MONTH = " + DateOfWorkedHoursPicker.Value.Month + " AND PROJECT_YEAR = " + DateOfWorkedHoursPicker.Value.Year;

                var projectMonthId = config.GetSingleValue(getProjectMonthIdQuery) as decimal?;

                if (projectMonthId == null)
                {
                    MessageBox.Show("Unable to add working hours. Contact administrator");
                    return;
                }

                string checkStatusQuery = $"SELECT PROJECT_MONTH_STATUS FROM PROJECT_MONTHS WHERE PROJECT_MONTH_ID = {projectMonthId}";

                var status = config.GetSingleValue(checkStatusQuery) as string;

                if (status == "C")
                {
                    MessageBox.Show("The month you try to report work hours has already been reported.");
                    return;
                }

                var checkHoursQuery = $"SELECT SUM(PROJECT_HOURS) FROM PROJECT_HOURS WHERE EMPLOYEE_ID = {this.employeeId} AND PROJECT_TASKDATE = '{DateOfWorkedHoursPicker.Text}' GROUP BY PROJECT_TASKDATE";

                var hours = this.config.GetSingleValue(checkHoursQuery) as decimal?;

                if (hours is null)
                {
                    hours = 0;
                }

                if (hours + int.Parse(MaxHours.Text) > 8)
                {
                    MessageBox.Show($"You have already reached maximum working hours for {DateOfWorkedHoursPicker.Text}");
                    return;
                }

                string sql = $"INSERT INTO PROJECT_HOURS(PROJECT_ID, EMPLOYEE_ID, PROJECT_TASKDATE, PROJECT_MONTH_ID, PROJECT_TASK, PROJECT_HOURS) VALUES (" + this.projectId.ToString() + "," + this.employeeId.ToString() + ",'" + DateOfWorkedHoursPicker.Text
                            + "'," + projectMonthId.ToString() + ",'" + DescriptionTextBox.Text + "'," + MaxHours.Text + ")";

                if (!config.Execute_CUD(sql))
                {
                    MessageBox.Show("Server error. Please contact administrator.");
                    return;
                }

                MessageBox.Show("Worked time reported successful");
                this.Close();
            }
        }
    }
}
