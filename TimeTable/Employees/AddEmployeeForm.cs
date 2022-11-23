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
    public partial class AddEmployeeForm : Form
    {
        private SQLConfig config;
        public AddEmployeeForm()
        {
            config = new SQLConfig();
            InitializeComponent();
        }


        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameTextBox.Text) ||
                String.IsNullOrEmpty(MiddleNameTextBox.Text) ||
                String.IsNullOrEmpty(LastNameTextBox.Text) ||
                EGNTextBox.TextLength != 10)
            {
                MessageBox.Show("Names and Personal Identification Number are required and must be correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO Employees(EMPLOYEE_EGN, EMPLOYEE_NAME, EMPLOYEE_SURNAME,EMPLOYEE_LASTNAME,EMPLOYEE_POSITION,EMPLOYEE_HIREDATE) "
                + "VALUES ('" + EGNTextBox.Text + "','" + FirstNameTextBox.Text + "','" + MiddleNameTextBox.Text
                + "','" + LastNameTextBox.Text + "','" + PositionDropdown.Text + "','" + StartingDate.Value + "')";

            if (config.Execute_CUD(sql))
            {
                MessageBox.Show("Succesfull added employee");
                this.Close();
            }
        }
    }
}
