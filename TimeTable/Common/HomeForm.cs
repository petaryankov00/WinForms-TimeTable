using System;
using System.Windows.Forms;
using TimeTable.Employees;
using TimeTable.Projects;

namespace TimeTable.Common
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void viewProjectsStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ProjectViewForm();
            this.ShowForm(form);
        }

        private void ShowForm(Form form)
        {
            CloseForm();

            form.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void CloseForm()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddProjectForm();
            this.ShowForm(form);
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm();
            this.ShowForm(form);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.loginToolStripMenuItem.Text == "Login")
            {
                var form = new LoginForm(this);
                this.ShowForm(form);
            }
            else
            {
                this.SetMenu(false);
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            this.ShowForm(form);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEmployeesStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new EmployeeViewForm();
            this.ShowForm(form);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.SetMenu(true);
        }

        public void SetMenu(bool isEnabled)
        {
            this.employeesToolStripMenuItem.Enabled = isEnabled;
            this.projectsToolStripMenuItem.Enabled = isEnabled;
            if (isEnabled)
            {
                this.loginToolStripMenuItem.Text = "Logout";
                this.registerToolStripMenuItem.Visible = false;
            }
            else
            {
                this.loginToolStripMenuItem.Text = "Login";
                this.registerToolStripMenuItem.Visible = true;
            }
        }
    }
}
