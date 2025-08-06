using ShopManager.Utilities;
using System;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class OrderStatusForm : Form
    {
        public string SelectedStatus { get; private set; }

        public OrderStatusForm(string currentStatus)
        {
            InitializeComponent();
            cbStatus.Items.AddRange(new[] { "Pending", "Processing", "Completed", "Cancelled" });
            cbStatus.SelectedItem = currentStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbStatus.SelectedItem == null)
                {
                    FormHelper.ShowError("Выберите статус");
                    return;
                }

                SelectedStatus = cbStatus.SelectedItem.ToString();
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