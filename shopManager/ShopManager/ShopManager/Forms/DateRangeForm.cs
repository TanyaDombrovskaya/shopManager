using ShopManager.Utilities;
using System;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class DateRangeForm : Form
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public DateRangeForm()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpStartDate.Value > dtpEndDate.Value)
                {
                    FormHelper.ShowError("Дата начала не может быть позже даты окончания");
                    return;
                }

                StartDate = dtpStartDate.Value;
                EndDate = dtpEndDate.Value;
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