using System;
using System.Windows.Forms;
using ShopManager.Data.Models;
using ShopManager.Utilities;

namespace ShopManager.Forms
{
    public partial class CategoryForm : Form
    {
        public Category Category { get; private set; }

        public CategoryForm()
        {
            InitializeComponent();
            Category = new Category();
            this.Text = "Добавить категорию";
        }

        public CategoryForm(Category category)
        {
            InitializeComponent();
            Category = category;
            this.Text = "Редактировать категорию";
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtName.Text = Category.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                FormHelper.ShowError("Введите название категории");
                txtName.Focus();
                return;
            }

            Category.Name = txtName.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}