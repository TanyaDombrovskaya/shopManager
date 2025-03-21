using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class RegistrationForm : Base
    {
        private LoginForm loginForm = new LoginForm();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string login = loginRegInput.Text;
            string password = passwordRegInput.Text;
            string name = nameInput.Text;
            string surname = surnameInput.Text;
            string email = emailInput.Text;

            if (!string.IsNullOrWhiteSpace(login) &&
                !string.IsNullOrWhiteSpace(password) &&
                !string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(surname) &&
                !string.IsNullOrWhiteSpace(email))
            {
                DatabaseManager dbManager = new DatabaseManager();

                if (dbManager.AddUser(login, password, name, surname, email))
                {
                    MessageBox.Show("Аккаунт был создан.");
                    this.Close();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не был создан.");
                }
            }
            else 
            {
                MessageBox.Show("Заполните все поля.");
            }
        }

        private void RegButton_MouseDown(object sender, MouseEventArgs e)
        {
            RegButton.BackColor = Color.White;
            RegButton.ForeColor = Color.Black;
        }

        private void RegButton_MouseUp(object sender, MouseEventArgs e)
        {
            RegButton.BackColor = Color.Black;
            RegButton.ForeColor = Color.White;
        }
    }
}
