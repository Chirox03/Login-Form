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
            username = usrBox.Text;
            password = passBox.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U8O149S;Encrypt=False;Initial Catalog=Login_demo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT into LOGIN_NEW(USERNAME,PASSWORD) VALUES ('" + username + "','"+ password + "')",conn);
            SqlDataReader tmp = cmd.ExecuteReader();
        }
    }
}
