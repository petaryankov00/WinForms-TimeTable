using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.Employees
{
    public partial class EmployeeViewForm : Form
    {
        public EmployeeViewForm()
        {
            InitializeComponent();
        }

        private void AddWorkedTimeButton_Click(object sender, EventArgs e)
        {
            var childForm = new AddWorkedTimeForm();
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }
    }
}
