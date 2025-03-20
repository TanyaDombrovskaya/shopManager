using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class RegistrationForm : Base
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string login = loginIRegInput.Text;
            string password = passwordRegInput.Text;
            string code = codeInput.Text;
            string name = nameInput.Text;
            string surname = surnameInput.Text;
            string email = emailInput.Text;


        }

        private void iLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите код админимтратора.");
        }
    }
}
