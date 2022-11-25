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
            }
        }
    }
}
