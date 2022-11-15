using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.Common;
using TimeTable.Config;

namespace TimeTable
{
    public partial class LoginForm : Form
    {
        private HomeForm form;
        private SQLConfig config;
        public LoginForm(HomeForm form)
        {
            InitializeComponent();
            this.form = form;
            this.config = new SQLConfig();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ACCOUNTS"
              + " WHERE Username = " + "'" + textBox1.Text + "'"
              + " AND Password = " + "'" + textBox2.Text + "'";
            config.SingleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                form.SetMenu(true);
                MessageBox.Show("Welcome " + config.dt.Rows[0].Field<string>("Username"));
                this.Close();
            }
            else
            {
                MessageBox.Show("", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
    }
}
