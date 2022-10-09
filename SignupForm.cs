using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string password, username;
            if(passBox.Text != repassBox.Text)
            {
                MessageBox.Show("Password doesn't match! Please retype password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(passBox.Text=="" || usrBox.Text=="" || repassBox.Text=="" )
            {
                MessageBox.Show("Invalid value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            username = usrBox.Text;
            password = passBox.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=10.0.141.4,1433;Encrypt=False;Initial Catalog=Login_demo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login_new where username= '" + username +"'", conn);
            SqlDataReader tmp = cmd.ExecuteReader();
            if (tmp.Read())
            {
                MessageBox.Show("Existed username! Please choose another!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            tmp.Close();
            cmd = new SqlCommand("INSERT into LOGIN_NEW(USERNAME,PASSWORD) VALUES ('" + username + "','"+ password + "')",conn);
            var tt = cmd.ExecuteNonQuery();
            MessageBox.Show("Success sign up! Please sign in to use the service!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.Show();
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
