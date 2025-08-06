using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService;

        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService(new Data.Repositories.UserRepository());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text;
                var confirmPassword = txtConfirmPassword.Text;
                var email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
                {
                    FormHelper.ShowError("Пожалуйста, заполните все поля");
                    return;
                }

                if (!IsValidUsername(username))
                {
                    FormHelper.ShowError("Логин должен содержать только латинские буквы и цифры");
                    return;
                }

                if (password.Length < 5)
                {
                    FormHelper.ShowError("Пароль должен быть не короче 5 символов");
                    return;
                }

                if (!IsValidPassword(password))
                {
                    FormHelper.ShowError("Пароль должен содержать только латинские буквы и цифры");
                    return;
                }

                if (password != confirmPassword)
                {
                    FormHelper.ShowError("Пароли не совпадают");
                    return;
                }

                if (!IsValidEmail(email))
                {
                    FormHelper.ShowError("Пожалуйста, введите корректный email");
                    return;
                }

                var user = _authService.Register(username, password, email);
                FormHelper.ShowInfo("Регистрация прошла успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^[a-zA-Z0-9]+$");
        }
    }
}