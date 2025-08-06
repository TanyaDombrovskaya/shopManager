using ShopManager.Data.Models;
using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class ManagerForm : Form
    {
        private readonly User _currentUser;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly ReportService _reportService;
        private readonly UserService _userService;
        private readonly string _connectionString;

        public ManagerForm(User user)
        {
            InitializeComponent();

            _currentUser = user;
            _connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;
            _productService = new ProductService(new Data.Repositories.ProductRepository());
            _orderService = new OrderService(
                new Data.Repositories.OrderRepository(),
                new Data.Repositories.ProductRepository(),
                _connectionString);
            _reportService = new ReportService();
            _userService = new UserService(new Data.Repositories.UserRepository());

            lblWelcome.Text = $"Добро пожаловать, {user.Username} (Менеджер)";
            LoadProducts();
            LoadOrders();

            dataGridViewOrders.RowPrePaint += DataGridViewOrders_RowPrePaint;
            dataGridViewProducts.RowPrePaint += DataGridViewProducts_RowPrePaint;

            this.FormClosed += (s, e) =>
            {
                dataGridViewOrders.RowPrePaint -= DataGridViewOrders_RowPrePaint;
                dataGridViewProducts.RowPrePaint -= DataGridViewProducts_RowPrePaint;
            };

            chkFilterByUser.CheckedChanged += ChkFilter_CheckedChanged;
            chkFilterByStatus.CheckedChanged += ChkFilter_CheckedChanged;
            btnFilter.Click += BtnFilter_Click;
            btnResetFilter.Click += BtnResetFilter_Click;
            UpdateComboBox();
        }

        private void DataGridViewProducts_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewProducts.Rows.Count)
                return;

            var row = dataGridViewProducts.Rows[e.RowIndex];
            var product = row.DataBoundItem as Product;

            if (product != null)
            {
                if (product.StockQuantity == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridViewProducts.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dataGridViewProducts.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void DataGridViewOrders_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewOrders.Rows.Count)
                return;

            var row = dataGridViewOrders.Rows[e.RowIndex];
            var statusCell = row.Cells["Status"];

            if (statusCell?.Value == null)
                return;

            string status = statusCell.Value.ToString();

            if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (status.Equals("Completed", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = dataGridViewOrders.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dataGridViewOrders.DefaultCellStyle.ForeColor;
            }
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts().ToList();
            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.Columns["Id"].Visible = false;
            dataGridViewProducts.Columns["CategoryId"].Visible = false;
            dataGridViewProducts.Columns["Description"].Visible = true;
            dataGridViewProducts.AutoResizeColumns();
            dataGridViewProducts.Refresh();
        }

        private void LoadOrders()
        {
            try
            {
                var orders = _orderService.GetAllOrders().ToList();

                var displayOrders = orders.Select(o => new
                {
                    o.Id,
                    o.UserId,
                    Username = _userService.GetUserById(o.UserId)?.Username ?? "Неизвестный пользователь",
                    o.OrderDate,
                    ItemsCount = o.Details.Count,
                    o.Status,
                    o.TotalAmount,
                    OriginalOrder = o
                }).ToList();

                dataGridViewOrders.DataSource = displayOrders;

                if (dataGridViewOrders.Columns.Contains("Id"))
                    dataGridViewOrders.Columns["Id"].Visible = false;
                if (dataGridViewOrders.Columns.Contains("UserId"))
                    dataGridViewOrders.Columns["UserId"].Visible = false;
                if (dataGridViewOrders.Columns.Contains("OriginalOrder"))
                    dataGridViewOrders.Columns["OriginalOrder"].Visible = false;

                dataGridViewOrders.RowPrePaint += DataGridViewOrders_RowPrePaint;

                if (orders.Any())
                {
                    dataGridViewOrderDetails.DataSource = orders.First().Details;
                    ConfigureOrderDetailsGrid();
                }
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка при загрузке заказов: {ex.Message}");
                Console.WriteLine($"LoadOrders error: {ex.ToString()}");
            }
        }

        private void ConfigureOrderDetailsGrid()
        {
            if (dataGridViewOrderDetails.Columns["Id"] != null)
                dataGridViewOrderDetails.Columns["Id"].Visible = false;
            if (dataGridViewOrderDetails.Columns["OrderId"] != null)
                dataGridViewOrderDetails.Columns["OrderId"].Visible = false;
            if (dataGridViewOrderDetails.Columns["ProductId"] != null)
                dataGridViewOrderDetails.Columns["ProductId"].Visible = false;
            if (dataGridViewOrderDetails.Columns["Description"] != null)
                dataGridViewOrderDetails.Columns["Description"].Visible = true; // Убедимся, что столбец Description виден
            dataGridViewOrderDetails.AutoResizeColumns(); // Автоматическая подгонка размеров столбцов
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var form = new ProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var product = form.Product;
                    _productService.AddProduct(product);
                    LoadProducts();
                    FormHelper.ShowInfo("Товар успешно добавлен");
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите товар");
                return;
            }

            var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
            using (var form = new ProductForm(selectedProduct))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var product = form.Product;
                    _productService.UpdateProduct(product);
                    LoadProducts();
                    FormHelper.ShowInfo("Товар успешно обновлен");
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите товар");
                return;
            }

            var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
            if (FormHelper.Confirm($"Удалить товар {selectedProduct.Name}?"))
            {
                if (_productService.DeleteProduct(selectedProduct.Id))
                {
                    FormHelper.ShowInfo("Товар успешно удален");
                    LoadProducts();
                }
                else
                {
                    FormHelper.ShowError("Ошибка при удалении товара");
                }
            }
        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите заказ");
                return;
            }

            var selectedRow = dataGridViewOrders.SelectedRows[0];
            var originalOrderProperty = selectedRow.DataBoundItem.GetType().GetProperty("OriginalOrder");

            if (originalOrderProperty == null || originalOrderProperty.GetValue(selectedRow.DataBoundItem) is not Order selectedOrder)
            {
                FormHelper.ShowError("Не удалось получить данные заказа");
                return;
            }

            if (selectedOrder.Status.Equals("Completed", StringComparison.OrdinalIgnoreCase) ||
                selectedOrder.Status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                FormHelper.ShowError("Невозможно изменить статус завершенного или отменённого заказа");
                return;
            }

            using (var form = new OrderStatusForm(selectedOrder.Status))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string newStatus = form.SelectedStatus;
                        bool success;

                        if (newStatus == "Cancelled")
                        {
                            success = _orderService.CancelOrder(selectedOrder.Id);
                            if (success)
                            {
                                _userService.AddBalance(selectedOrder.UserId, selectedOrder.TotalAmount); // Возврат средств
                                FormHelper.ShowInfo("Заказ успешно отменён, товары возвращены на склад, средства возвращены пользователю");
                            }
                            else
                            {
                                FormHelper.ShowError("Не удалось отменить заказ");
                            }
                        }
                        else
                        {
                            success = _orderService.UpdateOrderStatus(selectedOrder.Id, newStatus);
                            if (success)
                            {
                                FormHelper.ShowInfo("Статус заказа обновлен");
                            }
                            else
                            {
                                FormHelper.ShowError("Ошибка при обновлении статуса заказа");
                            }
                        }

                        if (success)
                        {
                            LoadOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        FormHelper.ShowError($"Ошибка при обновлении статуса: {ex.Message}");
                        Console.WriteLine($"UpdateOrderStatus error: {ex.ToString()}");
                    }
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите заказ");
                return;
            }

            var selectedRow = dataGridViewOrders.SelectedRows[0];
            var originalOrderProperty = selectedRow.DataBoundItem.GetType().GetProperty("OriginalOrder");

            if (originalOrderProperty == null || originalOrderProperty.GetValue(selectedRow.DataBoundItem) is not Order selectedOrder)
            {
                FormHelper.ShowError("Не удалось получить данные заказа");
                return;
            }

            if (FormHelper.Confirm($"Удалить заказ #{selectedOrder.Id}?"))
            {
                try
                {
                    if (_orderService.DeleteOrder(selectedOrder.Id))
                    {
                        FormHelper.ShowInfo("Заказ успешно удалён");
                        LoadOrders();
                        dataGridViewOrderDetails.DataSource = null;
                    }
                    else
                    {
                        FormHelper.ShowError("Ошибка при удалении заказа");
                    }
                }
                catch (Exception ex)
                {
                    FormHelper.ShowError($"Ошибка при удалении заказа: {ex.Message}");
                    Console.WriteLine($"DeleteOrder error: {ex.ToString()}");
                }
            }
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            using (var form = new DateRangeForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var report = _reportService.GetSalesReport(form.StartDate, form.EndDate);
                    decimal totalAmount = _reportService.GetSalesTotalAmount(form.StartDate, form.EndDate);
                    using (var reportForm = new ReportViewForm("Отчет о продажах", report, totalAmount))
                    {
                        reportForm.ShowDialog();
                    }
                }
            }
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            var report = _reportService.GetInventoryReport();
            decimal totalValue = _reportService.GetInventoryTotalValue();
            using (var reportForm = new ReportViewForm("Отчет по инвентаризации", report, totalValue))
            {
                reportForm.ShowDialog();
            }
        }

        private void btnTopProducts_Click(object sender, EventArgs e)
        {
            var report = _reportService.GetTopSellingProducts();
            using (var reportForm = new ReportViewForm("Топ продаваемых товаров", report))
            {
                reportForm.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl.SelectedTab?.Name)
                {
                    case "tabProducts":
                        LoadProducts();
                        FormHelper.ShowInfo("Список товаров обновлен");
                        break;
                    case "tabOrders":
                        LoadOrders();
                        FormHelper.ShowInfo("Список заказов обновлен");
                        break;
                    default:
                        LoadProducts();
                        LoadOrders();
                        FormHelper.ShowInfo("Данные обновлены");
                        break;
                }
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка при обновлении данных: {ex.Message}");
                Console.WriteLine($"Refresh error: {ex.ToString()}");
            }
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                var originalOrderProperty = selectedRow.DataBoundItem.GetType().GetProperty("OriginalOrder");

                if (originalOrderProperty != null && originalOrderProperty.GetValue(selectedRow.DataBoundItem) is Order selectedOrder)
                {
                    try
                    {
                        dataGridViewOrderDetails.DataSource = selectedOrder.Details;
                        ConfigureOrderDetailsGrid();

                        btnUpdateOrderStatus.Enabled = !selectedOrder.Status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                                                      !selectedOrder.Status.Equals("Completed", StringComparison.OrdinalIgnoreCase);
                    }
                    catch (Exception ex)
                    {
                        FormHelper.ShowError($"Ошибка при загрузке деталей заказа: {ex.Message}");
                    }
                }
            }
        }

        private void ChkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == chkFilterByUser && chkFilterByUser.Checked)
            {
                chkFilterByStatus.Checked = false;
            }
            else if (sender == chkFilterByStatus && chkFilterByStatus.Checked)
            {
                chkFilterByUser.Checked = false;
            }

            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            comboFilter.Items.Clear();

            if (chkFilterByUser.Checked)
            {
                var users = _userService.GetAllUsers()
                    .Where(u => u.Role.Equals("User", StringComparison.OrdinalIgnoreCase))
                    .Select(u => u.Username)
                    .Distinct()
                    .ToList();
                comboFilter.Items.AddRange(users.ToArray());
            }
            else if (chkFilterByStatus.Checked)
            {
                var statuses = _orderService.GetAllOrders().Select(o => o.Status).Distinct().ToList();
                comboFilter.Items.AddRange(statuses.ToArray());
            }

            comboFilter.Enabled = chkFilterByUser.Checked || chkFilterByStatus.Checked;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chkFilterByUser.Checked && !chkFilterByStatus.Checked)
                {
                    FormHelper.ShowError("Выберите фильтры");
                    return;
                }

                if (comboFilter.SelectedItem == null)
                {
                    FormHelper.ShowError("Выберите значение для фильтрации");
                    return;
                }

                var orders = _orderService.GetAllOrders().ToList();
                var displayOrders = orders.Select(o => new
                {
                    o.Id,
                    o.UserId,
                    Username = _userService.GetUserById(o.UserId)?.Username ?? "Неизвестный пользователь",
                    o.OrderDate,
                    ItemsCount = o.Details.Count,
                    o.Status,
                    o.TotalAmount,
                    OriginalOrder = o
                }).ToList();

                if (chkFilterByUser.Checked && comboFilter.SelectedItem != null)
                {
                    string selectedUser = comboFilter.SelectedItem.ToString();
                    displayOrders = displayOrders.Where(o => o.Username == selectedUser).ToList();
                }
                else if (chkFilterByStatus.Checked && comboFilter.SelectedItem != null)
                {
                    string selectedStatus = comboFilter.SelectedItem.ToString();
                    displayOrders = displayOrders.Where(o => o.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridViewOrders.DataSource = displayOrders;

                if (dataGridViewOrders.Columns.Contains("Id"))
                    dataGridViewOrders.Columns["Id"].Visible = false;
                if (dataGridViewOrders.Columns.Contains("UserId"))
                    dataGridViewOrders.Columns["UserId"].Visible = false;
                if (dataGridViewOrders.Columns.Contains("OriginalOrder"))
                    dataGridViewOrders.Columns["OriginalOrder"].Visible = false;

                dataGridViewOrders.RowPrePaint += DataGridViewOrders_RowPrePaint;

                if (displayOrders.Any())
                {
                    dataGridViewOrderDetails.DataSource = displayOrders.First().OriginalOrder.Details;
                    ConfigureOrderDetailsGrid();
                }
                else
                {
                    dataGridViewOrderDetails.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка при фильтрации заказов: {ex.Message}");
                Console.WriteLine($"Filter error: {ex.ToString()}");
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            chkFilterByUser.Checked = false;
            chkFilterByStatus.Checked = false;
            comboFilter.Items.Clear();
            comboFilter.Enabled = false;
            LoadOrders();
        }
    }
}