using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginForm
{
    public partial class LoginSuccess : Form
    {
        public LoginSuccess()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            LoginForm newLogin = new LoginForm();
            this.Close();
            newLogin.Show();

        }
    }
}
