using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaHuyHoang
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ok, next time will be go to Main Menu of App");
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Usernam or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
