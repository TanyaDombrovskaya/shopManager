using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class TopUpBalanceForm : Form
    {
        private readonly int _userId;
        private readonly UserService _userService;

        public TopUpBalanceForm(int userId, UserService userService)
        {
            InitializeComponent();
            _userId = userId;
            _userService = userService;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                if (_userService.AddBalance(_userId, amount))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    FormHelper.ShowError("Ошибка при пополнении баланса");
                }
            }
            else
            {
                FormHelper.ShowError("Введите корректную сумму больше 0");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}