using System;
using System.Windows.Forms;
using ShopManager.Data.Models;
using ShopManager.Services;
using ShopManager.Utilities;

namespace ShopManager.Forms
{
    public partial class CategoryManagerForm : Form
    {
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;

        public CategoryManagerForm()
        {
            InitializeComponent();
            _categoryService = new CategoryService(new Data.Repositories.CategoryRepository());
            _productService = new ProductService(new Data.Repositories.ProductRepository());
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                dataGridViewCategories.DataSource = categories;

                if (dataGridViewCategories.Columns.Contains("Id"))
                    dataGridViewCategories.Columns["Id"].Visible = false;

                dataGridViewCategories.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _categoryService.AddCategory(form.Category);
                    LoadCategories();
                    FormHelper.ShowInfo("Категория добавлена");
                }
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Выберите категорию для редактирования");
                return;
            }

            var selectedCategory = (Category)dataGridViewCategories.SelectedRows[0].DataBoundItem;
            using (var form = new CategoryForm(selectedCategory))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _categoryService.UpdateCategory(form.Category);
                    LoadCategories();
                    FormHelper.ShowInfo("Категория обновлена");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Выберите категорию для удаления");
                return;
            }

            var selectedCategory = (Category)dataGridViewCategories.SelectedRows[0].DataBoundItem;
            var productsInCategory = _productService.GetProductsByCategory(selectedCategory.Id);
            if (productsInCategory.Any())
            {
                FormHelper.ShowError("Нельзя удалить категорию, так как в ней есть товары");
                return;
            }

            if (FormHelper.Confirm($"Удалить категорию '{selectedCategory.Name}'?"))
            {
                try
                {
                    _categoryService.DeleteCategory(selectedCategory.Id);
                    LoadCategories();
                    FormHelper.ShowInfo("Категория удалена");
                }
                catch (Exception ex)
                {
                    FormHelper.ShowError($"Ошибка удаления: {ex.Message}");
                }
            }
        }
    }
}