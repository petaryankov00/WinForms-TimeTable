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

namespace TimeTable
{
    public partial class RegisterForm : Form
    {
        private SQLConfig config;
        public RegisterForm()
        {
            InitializeComponent();
            this.config = new SQLConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.TextLength < 4 || this.passwordTextBox.TextLength < 4 || this.confirmPasswordTextBox.TextLength < 4)
            {
                MessageBox.Show("All fields are required and must be at least 4 symbols", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (this.passwordTextBox.Text != this.confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords should match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO ACCOUNTS VALUES ('" + this.usernameTextBox.Text + "', '" +  this.passwordTextBox.Text + "')";

            config.Execute_CUD(sql, "Error while register account", "Succesfull created account");

            this.Close();
        }
    }
}
