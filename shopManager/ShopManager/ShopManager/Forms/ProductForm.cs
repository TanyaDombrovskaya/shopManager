using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using ShopManager.Data.Models;
using ShopManager.Utilities;

namespace ShopManager.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }
        private readonly string connectionString;

        public ProductForm(Product product = null)
        {
            InitializeComponent();
            Product = product ?? new Product();
            connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;
            LoadCategories();
            PopulateFields();
        }

        private void LoadCategories()
        {
            try
            {
                cbCategory.Items.Clear();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM categories";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbCategory.Items.Add(new ComboBoxItem
                                {
                                    Value = reader.GetInt32(0),
                                    Text = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
                cbCategory.Items.Insert(0, new ComboBoxItem { Value = null, Text = "Без категории" });
                cbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void PopulateFields()
        {
            if (Product.Id > 0)
            {
                txtName.Text = Product.Name;
                txtDescription.Text = Product.Description;
                numPrice.Value = Product.Price;
                numStockQuantity.Value = Product.StockQuantity;
                if (Product.CategoryId.HasValue)
                {
                    foreach (ComboBoxItem item in cbCategory.Items)
                    {
                        if (item.Value != null && (int)item.Value == Product.CategoryId)
                        {
                            cbCategory.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    FormHelper.ShowError("Введите название товара");
                    return;
                }

                if (numPrice.Value <= 0)
                {
                    FormHelper.ShowError("Цена должна быть больше 0");
                    return;
                }

                Product.Name = txtName.Text.Trim();
                Product.Description = txtDescription.Text.Trim();
                Product.Price = numPrice.Value;
                Product.StockQuantity = (int)numStockQuantity.Value;
                Product.CategoryId = ((ComboBoxItem)cbCategory.SelectedItem).Value != null
                    ? (int?)((ComboBoxItem)cbCategory.SelectedItem).Value
                    : null;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryManagerForm())
            {
                form.ShowDialog();
                LoadCategories();
                PopulateFields();
            }
        }

        private class ComboBoxItem
        {
            public int? Value { get; set; }
            public string Text { get; set; }
            public override string ToString() => Text;
        }
    }
}