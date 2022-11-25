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
    public partial class AddProjectForm : Form
    {
        private SQLConfig config;
        public AddProjectForm()
        {
            this.config = new SQLConfig();
            InitializeComponent();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ProjectNameTextBox.Text) ||
               String.IsNullOrEmpty(DescriptionTextBox.Text) ||
               String.IsNullOrEmpty(MaxHours.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO PROJECT(PROJECT_NAME, PROJECT_DESCRIPTION, PROJECT_BEGIN,PROJECT_END,PROJECT_STATUS,PROJECT_MAXHOURS) "
                + "VALUES ('" + ProjectNameTextBox.Text + "','" + DescriptionTextBox.Text + "','" + StartDate.Text
                + "','" + EndDate.Text + "','O','" + MaxHours.Text + "')";

            if (config.Execute_CUD(sql))
            {
                string getIdQuery = "SELECT PROJECT_ID FROM PROJECT WHERE PROJECT_NAME = '" + ProjectNameTextBox.Text + "' AND PROJECT_DESCRIPTION = '" + DescriptionTextBox.Text + "'";

                var id = config.GetSingleValue(getIdQuery) as decimal?;

                if(id != null)
                {
                    var projectMonths = this.GetMonthsBetween(StartDate.Value, EndDate.Value);

                    foreach (var date in projectMonths)
                    {
                        string query = "INSERT INTO PROJECT_MONTHS(PROJECT_ID, PROJECT_YEAR, PROJECT_MONTH,PROJECT_MONTH_STATUS)"
                        + "VALUES (" + id + "," + date.Year + "," + date.Month
                        + ",'O')";

                        config.Execute_CUD(query);
                    }
                }

                MessageBox.Show("Successful created project");
                this.Close();
            }
        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {
            this.StartDate.MinDate = DateTime.Now;
            this.EndDate.MinDate = DateTime.Now.AddMonths(1);
        }

        public List<DateTime> GetMonthsBetween(DateTime from, DateTime to)
        {
            List<DateTime> results = new List<DateTime>();
            for (var i = from; i <= to; i = i.AddMonths(1))
            {
                if (i.Month == 12 && results.Contains(i))
                {
                    from = from.AddYears(1);
                    from = new DateTime(from.Year, 1, 1);
                    i = from;
                }
                results.Add(i);
            }

            return results;
        }
    }
}
