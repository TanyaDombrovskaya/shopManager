using Microsoft.VisualBasic.ApplicationServices;
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

            DatabaseManager dbm = new DatabaseManager();

            (string user, string dostup) = dbm.ChooseDostup();

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(dostup))
            {
                Form nextForm = null;

                if (dostup.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    nextForm = new AdminForm();

                    ((AdminForm)nextForm).NameAdmin = user;
                }
                else if (dostup.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    nextForm = new UserForm();

                    ((UserForm)nextForm).NameUser = user;
                }
                else
                {
                    MessageBox.Show("Неизвестный уровень доступа.");
                    return; 
                }

                this.Close();
                Application.Run(nextForm);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Text;

            DatabaseManager dbManager1 = new DatabaseManager();
            string role = dbManager1.GetUser(login, password);

            if (role != null)
            {
                DatabaseManager dbManager2 = new DatabaseManager();
                bool result = dbManager2.UserConnect(login);

                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();

                    adminform.NameAdmin = login;
                }
                else if (role.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    UserForm userform = new UserForm();
                    userform.Show();

                    userform.NameUser = login;
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
