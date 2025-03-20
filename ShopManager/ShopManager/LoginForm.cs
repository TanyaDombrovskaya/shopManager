using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class LoginForm : Base
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Text;

            DatabaseManager dbManager = new DatabaseManager();
            string role = dbManager.GetUser(login, password);

            if (role != null)
            {
                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                else if (role.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    UserForm userform = new UserForm();
                    userform.Show();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден.");
            }
        }

        private void loginButton_MouseDown(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.Black;
        }

        private void loginButton_MouseUp(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.Black;
            loginButton.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
