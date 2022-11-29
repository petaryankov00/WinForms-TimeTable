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
    public partial class EmployeeProjectsForm : Form
    {
        private decimal employeeId;
        private decimal currentProjectId;
        private bool isReadyForEdit = false;
        private SQLConfig config;

        public EmployeeProjectsForm(decimal employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.config = new SQLConfig();
        }

        private void EmployeeProjectsForm_Load(object sender, EventArgs e)
        {
            string query = $"SELECT p.PROJECT_ID as [Project ID],p.PROJECT_NAME as [Project], ph.PROJECT_TASKDATE as [Date], ph.PROJECT_TASK as [Task Description], ph.PROJECT_HOURS as [Hours], p.PROJECT_STATUS as [Project Status]" +
                $"FROM PROJECT_HOURS as ph JOIN PROJECT as p ON ph.PROJECT_ID = p.PROJECT_ID WHERE ph.EMPLOYEE_ID = {this.employeeId}";


            config.Load_DTG(query, EmployeeProjectsGridView);
        }

        private void EmployeeProjectsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.EmployeeProjectsGridView.Rows[e.RowIndex];
                this.currentProjectId = (decimal)row.Cells["Project ID"].Value;
                ProjectNameTextBox.Text = row.Cells["Project"].Value.ToString();
                DateOfWorkedHoursPicker.Text = row.Cells["Date"].Value.ToString();
                DescriptionTextBox.Text = row.Cells["Task Description"].Value.ToString();
                Hours.Text = row.Cells["Hours"].Value.ToString();
                this.isReadyForEdit = row.Cells["Project Status"].Value.ToString() == "O" ? true : false;
                DateOfWorkedHoursPicker.Enabled = false;

            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (isReadyForEdit)
            {
                if (String.IsNullOrEmpty(DescriptionTextBox.Text))
                {
                    MessageBox.Show("You cannot enter empty description.");
                    return;
                }

                var getMaxHoursQuery = $"SELECT PROJECT_MAXHOURS FROM PROJECT WHERE PROJECT_ID = {this.currentProjectId}";
                var projectMaxHours = this.config.GetSingleValue(getMaxHoursQuery) as decimal?;

                if (projectMaxHours is null || projectMaxHours < int.Parse(Hours.Text))
                {
                    MessageBox.Show($"Working hours should be less or equal to {projectMaxHours} for this project.");
                    return;
                }

                var checkHoursQuery = $"SELECT SUM(PROJECT_HOURS) FROM PROJECT_HOURS WHERE EMPLOYEE_ID = {this.employeeId} AND PROJECT_TASKDATE = '{DateOfWorkedHoursPicker.Text}' GROUP BY PROJECT_TASKDATE";

                var hours = (decimal)this.config.GetSingleValue(checkHoursQuery);

                if (hours + int.Parse(Hours.Text) > 8)
                {
                    MessageBox.Show($"You have already reached maximum working hours for {DateOfWorkedHoursPicker.Text}");
                    return;
                }

                var query = $"UPDATE PROJECT_HOURS SET PROJECT_TASKDATE = '{DateOfWorkedHoursPicker.Text}', PROJECT_TASK = '{DescriptionTextBox.Text}', PROJECT_HOURS = {Hours.Text} " +
                    $"WHERE PROJECT_ID = {this.currentProjectId} AND EMPLOYEE_ID = {this.employeeId} AND PROJECT_TASKDATE = '{DateOfWorkedHoursPicker.Text}'";

                if (!config.Execute_CUD(query))
                {
                    MessageBox.Show($"Unable to update project task information. Please contact administrator for help.");
                    return;
                }

                MessageBox.Show("Information updated successfully");

                this.EmployeeProjectsForm_Load(sender, e);
                this.CancelButton_Click(sender, e);
                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProjectNameTextBox.Text = "";
            DateOfWorkedHoursPicker.Text = null;
            DescriptionTextBox.Text = "";
            Hours.Text = null;
            this.isReadyForEdit = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (isReadyForEdit)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task information?", "Warning", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    string query = $"DELETE FROM PROJECT_HOURS WHERE PROJECT_ID = {this.currentProjectId} AND EMPLOYEE_ID = {this.employeeId} AND PROJECT_TASKDATE = '{DateOfWorkedHoursPicker.Text}'";


                    if (this.config.Execute_CUD(query))
                    {
                       MessageBox.Show("Successfully deleted information");
                       this.EmployeeProjectsForm_Load(sender, e);
                       this.CancelButton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete task information. Please contact administrator.");
                    }

                }
            }
        }
    }
}
