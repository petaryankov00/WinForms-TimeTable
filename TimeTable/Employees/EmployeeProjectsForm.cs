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
        private SQLConfig config;

        public EmployeeProjectsForm(decimal employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.config = new SQLConfig();
        }

        private void EmployeeProjectsForm_Load(object sender, EventArgs e)
        {
            string query = $"SELECT p.PROJECT_NAME as [Project], ph.PROJECT_TASKDATE as [Date], ph.PROJECT_TASK as [Task Description], ph.PROJECT_HOURS as [Hours]" +
                $"FROM PROJECT_HOURS as ph JOIN PROJECT as p ON ph.PROJECT_ID = p.PROJECT_ID WHERE ph.EMPLOYEE_ID = {this.employeeId}";

            config.Load_DTG(query, EmployeeProjectsGridView);
        }
    }
}
