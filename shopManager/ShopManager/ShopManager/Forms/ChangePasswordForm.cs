using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ShopManager.Data.Models;
using ShopManager.Services;
using ShopManager.Utilities;

namespace ShopManager.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly User _currentUser;
        private readonly AuthService _authService;

        public ChangePasswordForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _authService = new AuthService(new Data.Repositories.UserRepository());
            this.Text = "Смена пароля";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                FormHelper.ShowError("Все поля должны быть заполнены");
                return;
            }

            if (!IsValidEmail(email))
            {
                FormHelper.ShowError("Введите корректный email");
                return;
            }

            if (email != _currentUser.Email)
            {
                FormHelper.ShowError("Указанный email не соответствует вашему зарегистрированному email");
                return;
            }

            if (newPassword != confirmPassword)
            {
                FormHelper.ShowError("Новый пароль и подтверждение не совпадают");
                return;
            }

            if (newPassword.Length < 6)
            {
                FormHelper.ShowError("Новый пароль должен содержать минимум 6 символов");
                return;
            }

            string newPasswordHash = PasswordHasher.HashPassword(newPassword);
            _currentUser.PasswordHash = newPasswordHash;

            if (_authService.UpdateUser(_currentUser))
            {
                FormHelper.ShowInfo("Пароль успешно изменен");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                FormHelper.ShowError("Ошибка при изменении пароля");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}