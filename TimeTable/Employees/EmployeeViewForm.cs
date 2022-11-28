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
    public partial class EmployeeViewForm : Form
    {
        private SQLConfig config;
        private bool isReadyForUpdate = false;
        private decimal currentEmployeeId;

        public EmployeeViewForm()
        {
            config = new SQLConfig();
            InitializeComponent();
        }

        private void AddWorkedTimeButton_Click(object sender, EventArgs e)
        {
            if (isReadyForUpdate)
            {
                var childForm = new AddWorkedTimeForm(this.currentEmployeeId);
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
            }
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT EMPLOYEE_ID as ID,EMPLOYEE_EGN as EGN, EMPLOYEE_NAME as [First Name], EMPLOYEE_SURNAME as [Middle Name],EMPLOYEE_LASTNAME as [Last Name],EMPLOYEE_POSITION as [Position],EMPLOYEE_HIREDATE as [Start Date] FROM EMPLOYEES WHERE EMPLOYEE_EGN LIKE '%"
                + SearchBox.Text + "%' OR CONCAT(EMPLOYEE_NAME, ' ',EMPLOYEE_SURNAME, ' ',EMPLOYEE_LASTNAME) LIKE '%" + SearchBox.Text + "%' OR EMPLOYEE_POSITION LIKE '%" + SearchBox.Text + "%'";

            config.Load_DTG(sql, AllEmployeesGridView);
        }

        private void AllEmployeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.AllEmployeesGridView.Rows[e.RowIndex];
                this.currentEmployeeId = (decimal)row.Cells["ID"].Value;
                FirstNameTextBox.Text = row.Cells["First Name"].Value.ToString();
                MiddleNameTextBox.Text = row.Cells["Middle Name"].Value.ToString();
                LastNameTextBox.Text = row.Cells["Last Name"].Value.ToString();
                EGNTextBox.Text = row.Cells["EGN"].Value.ToString();
                PositionDropdown.Text = row.Cells["Position"].Value.ToString();
                StartingDate.Text = row.Cells["Start Date"].Value.ToString();
            }

            string query = "SELECT PROJECT_MONTH as Month, PROJECT_YEAR as Year, SUM(PROJECT_HOURS) as [Hours] FROM PROJECT_HOURS as ph JOIN PROJECT_MONTHS as pm ON ph.[PROJECT_MONTH_ID] = pm.[PROJECT_MONTH_ID] JOIN EMPLOYEES as e ON ph.employee_id = e.employee_id WHERE e.employee_egn = '" + EGNTextBox.Text + "' GROUP BY PROJECT_MONTH,PROJECT_YEAR";
            this.isReadyForUpdate = true;

            config.Load_DTG(query, WorkedHoursGridView);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (isReadyForUpdate)
            {
                if (String.IsNullOrEmpty(FirstNameTextBox.Text) ||
                String.IsNullOrEmpty(MiddleNameTextBox.Text) ||
                String.IsNullOrEmpty(LastNameTextBox.Text) ||
                EGNTextBox.TextLength != 10)
                {
                    MessageBox.Show("Names and Personal Identification Number are required and must be correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE Employees SET EMPLOYEE_NAME = '" + FirstNameTextBox.Text + "', EMPLOYEE_SURNAME = '" + MiddleNameTextBox.Text
                    + "', EMPLOYEE_LASTNAME = '" + LastNameTextBox.Text + "', EMPLOYEE_POSITION = '" + PositionDropdown.Text + "', EMPLOYEE_HIREDATE = '" + StartingDate.Text + "' WHERE EMPLOYEE_EGN = '" + EGNTextBox.Text + "'";

                if (config.Execute_CUD(query))
                {
                    MessageBox.Show("Empoyee inforamtion updated");
                    this.SearchButton_Click(sender, e);
                    this.CancelButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Unable to update employee information. Please contact administrator.");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EGNTextBox.Text = "";
            PositionDropdown.Text = "";
            StartingDate.Value = DateTime.Now;
            WorkedHoursGridView.DataSource = null;
            this.isReadyForUpdate = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.isReadyForUpdate)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    string queryForHours = $"DELETE FROM PROJECT_HOURS WHERE EMPLOYEE_ID = {this.currentEmployeeId}";
                    string queryForEmployees = $"DELETE FROM EMPLOYEES WHERE EMPLOYEE_ID = {this.currentEmployeeId}";


                    if (this.config.Execute_CUD(queryForHours))
                    {
                        if (this.config.Execute_CUD(queryForEmployees))
                        {
                            MessageBox.Show("Successfull deleted employee");
                            this.SearchButton_Click(sender, e);
                            this.CancelButton_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete employee. Please contact administrator.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Unable to delete employee. Please contact administrator.");
                    }

                }
            }
        }

        private void ViewProjectsButton_Click(object sender, EventArgs e)
        {
            if (this.isReadyForUpdate)
            {
                var childForm = new EmployeeProjectsForm(this.currentEmployeeId);
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
            }
        }
    }
}
