using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(new Data.Repositories.UserRepository());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("=== Login process started ===");

                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text;

                Console.WriteLine($"Username: {username}, Password: [hidden]");

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Validation failed: Empty username or password");
                    FormHelper.ShowError("Пожалуйста, введите имя пользователя и пароль");
                    return;
                }

                Console.WriteLine("Calling AuthService.Login...");
                var user = _authService.Login(username, password);
                Console.WriteLine($"AuthService returned: {(user != null ? "User" : "NULL")}");

                if (user == null)
                {
                    Console.WriteLine("Login failed: Null user returned");
                    FormHelper.ShowError("Неверное имя пользователя или пароль");
                    return;
                }

                if (user.Role == null)
                {
                    Console.WriteLine("Critical: User role is NULL");
                    user.Role = "User";
                }

                Console.WriteLine($"User role: {user.Role}, IsBanned: {user.IsBanned}");

                if (user.IsBanned)
                {
                    Console.WriteLine("Login failed: User is banned");
                    FormHelper.ShowError("Ваш аккаунт заблокирован. Обратитесь к администратору.");
                    return;
                }

                Console.WriteLine("Creating appropriate form...");
                Form nextForm = null;

                switch (user.Role.ToLower())
                {
                    case "admin":
                        nextForm = new AdminForm(user);
                        break;
                    case "manager":
                        nextForm = new ManagerForm(user);
                        break;
                    default:
                        nextForm = new UserForm(user);
                        break;
                }

                if (nextForm == null)
                {
                    Console.WriteLine("Form creation failed!");
                    throw new Exception("Не удалось создать форму для пользователя");
                }

                Console.WriteLine($"Opening {nextForm.GetType().Name}...");
                FormHelper.OpenFormAndCloseCurrent(nextForm, this);
                Console.WriteLine("=== Login process completed successfully ===");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"!!! LOGIN ERROR: {ex.ToString()}");
                FormHelper.ShowError($"Ошибка входа: {ex.Message}");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void linkChangePass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                FormHelper.ShowError("Пожалуйста, введите имя пользователя");
                return;
            }

            var user = _authService.GetUserByUsername(username);
            if (user == null)
            {
                FormHelper.ShowError("Пользователь не найден");
                return;
            }

            var changePasswordForm = new ChangePasswordForm(user);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                txtPassword.Text = "";
                FormHelper.ShowInfo("Пароль успешно изменен. Войдите с новым паролем.");
            }
        }
    }
}