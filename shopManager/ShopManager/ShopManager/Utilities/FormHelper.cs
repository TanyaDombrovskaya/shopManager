using System;
using System.Windows.Forms;

namespace ShopManager.Utilities
{
    public static class FormHelper
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(string question)
        {
            return MessageBox.Show(question, "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void OpenFormAndCloseCurrent(Form newForm, Form currentForm)
        {
            newForm.FormClosed += (s, args) => currentForm.Close();
            currentForm.Hide();
            newForm.Show();
        }
    }
}