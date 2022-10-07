
using Microsoft.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usrBox.Text;
            password = passBox.Text;
            if(username=="" || password=="")
            {
                MessageBox.Show("Invalid username or password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U8O149S;Encrypt=False;Initial Catalog=Login_demo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login_new where username= '" + username + "'and password='" + password + "'", conn);
            SqlDataReader tmp = cmd.ExecuteReader();
            if(tmp.Read())
            {
                this.Hide();
                LoginSuccess successForm = new LoginSuccess();
                successForm.Show();
               // this.Close();

            }else
            {
                MessageBox.Show("Wrong password or username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void signupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm form = new SignupForm();
            form.ShowDialog();

        }
    }
}