using ShopManager.Utilities;
using System;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class RoleSelectionForm : Form
    {
        public string SelectedRole { get; private set; }

        public RoleSelectionForm(string currentRole)
        {
            InitializeComponent();
            cbRole.Items.AddRange(new[] { "Admin", "Manager", "User" });
            cbRole.SelectedItem = currentRole;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbRole.SelectedItem == null)
                {
                    FormHelper.ShowError("Выберите роль");
                    return;
                }

                SelectedRole = cbRole.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка: {ex.Message}");
            }
        }
    }
}