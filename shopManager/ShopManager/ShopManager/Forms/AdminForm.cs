using ShopManager.Data.Models;
using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class AdminForm : Form
    {
        private readonly User _currentUser;
        private readonly UserService _userService;

        public AdminForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
            _userService = new UserService(new Data.Repositories.UserRepository());

            lblWelcome.Text = $"Добро пожаловать, {user.Username} (Администратор)";

            dataGridViewUsers.RowPrePaint += DataGridViewUsers_RowPrePaint;

            LoadUsers();

            this.FormClosed += (s, e) =>
            {
                dataGridViewUsers.RowPrePaint -= DataGridViewUsers_RowPrePaint;
            };
        }

        private void DataGridViewUsers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewUsers.Rows.Count)
                return;

            var row = dataGridViewUsers.Rows[e.RowIndex];
            var user = row.DataBoundItem as User;

            if (user != null && user.IsBanned)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
                row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = dataGridViewUsers.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dataGridViewUsers.DefaultCellStyle.ForeColor;
                row.DefaultCellStyle.SelectionBackColor = dataGridViewUsers.DefaultCellStyle.SelectionBackColor;
                row.DefaultCellStyle.SelectionForeColor = dataGridViewUsers.DefaultCellStyle.SelectionForeColor;
            }
        }

        private void LoadUsers()
        {
            var users = _userService.GetAllUsers().ToList();
            dataGridViewUsers.DataSource = users;
            dataGridViewUsers.Columns["PasswordHash"].Visible = false;
            dataGridViewUsers.Columns["Id"].Visible = false;
            dataGridViewUsers.Refresh();
        }

        private void btnBanUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите пользователя");
                return;
            }

            var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            if (selectedUser.Id == _currentUser.Id)
            {
                FormHelper.ShowError("Вы не можете заблокировать себя");
                return;
            }

            if (FormHelper.Confirm($"Заблокировать пользователя {selectedUser.Username}?"))
            {
                if (_userService.BanUser(selectedUser.Id))
                {
                    FormHelper.ShowInfo("Пользователь заблокирован");
                    LoadUsers();
                }
                else
                {
                    FormHelper.ShowError("Ошибка при блокировке пользователя");
                }
            }
        }

        private void btnUnbanUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите пользователя");
                return;
            }

            var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            if (FormHelper.Confirm($"Разблокировать пользователя {selectedUser.Username}?"))
            {
                if (_userService.UnbanUser(selectedUser.Id))
                {
                    FormHelper.ShowInfo("Пользователь разблокирован");
                    LoadUsers();
                }
                else
                {
                    FormHelper.ShowError("Ошибка при разблокировке пользователя");
                }
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите пользователя");
                return;
            }

            var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            if (selectedUser.Id == _currentUser.Id)
            {
                FormHelper.ShowError("Вы не можете изменить свою роль");
                return;
            }

            using (var roleForm = new RoleSelectionForm(selectedUser.Role))
            {
                if (roleForm.ShowDialog() == DialogResult.OK)
                {
                    if (_userService.ChangeUserRole(selectedUser.Id, roleForm.SelectedRole))
                    {
                        FormHelper.ShowInfo("Роль пользователя изменена");
                        LoadUsers();
                    }
                    else
                    {
                        FormHelper.ShowError("Ошибка при изменении роли пользователя");
                    }
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите пользователя");
                return;
            }

            var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            if (selectedUser.Id == _currentUser.Id)
            {
                FormHelper.ShowError("Вы не можете удалить себя");
                return;
            }

            if (FormHelper.Confirm($"Удалить пользователя {selectedUser.Username}?"))
            {
                if (_userService.DeleteUser(selectedUser.Id))
                {
                    FormHelper.ShowInfo("Пользователь удален");
                    LoadUsers();
                }
                else
                {
                    FormHelper.ShowError("Ошибка при удалении пользователя");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}