using ShopManager.Data.Models;
using ShopManager.Services;
using ShopManager.Utilities;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class UserForm : Form
    {
        private readonly User _currentUser;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly string _connectionString;
        private readonly UserService _userService;

        public UserForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _connectionString = ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString;
            _productService = new ProductService(new Data.Repositories.ProductRepository());
            _orderService = new OrderService(
                new Data.Repositories.OrderRepository(),
                new Data.Repositories.ProductRepository(),
                _connectionString);
            _userService = new UserService(new Data.Repositories.UserRepository());
            lblWelcome.Text = $"Добро пожаловать, {user.Username} (Пользователь)";
            LoadProducts();
            LoadOrders();
            lblBalanceValue.Text = $"{_userService.GetBalance(_currentUser.Id):F2} ₽";
            btnTopUpBalance.Click += btnTopUpBalance_Click;
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts()
                             .Where(p => p.StockQuantity > 0)
                             .ToList();

            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.Columns["Id"].Visible = false;
            dataGridViewProducts.Columns["CategoryId"].Visible = false;

            if (dataGridViewProducts.Columns["Select"] == null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Выбрать",
                    Name = "Select",
                    Width = 50,
                    ReadOnly = false
                };
                dataGridViewProducts.Columns.Insert(0, checkBoxColumn);
                dataGridViewProducts.CellValueChanged += DataGridViewProducts_CellValueChanged;
                dataGridViewProducts.CurrentCellDirtyStateChanged += DataGridViewProducts_CurrentCellDirtyStateChanged;
            }
            dataGridViewProducts.ReadOnly = false;
            dataGridViewProducts.MultiSelect = true;
        }

        private void DataGridViewProducts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.IsCurrentCellDirty)
            {
                dataGridViewProducts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) 
            {
                var row = dataGridViewProducts.Rows[e.RowIndex];
                var checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBox != null && checkBox.Value != null)
                {
                    bool isChecked = (bool)checkBox.Value;
                    row.Selected = isChecked;
                }
            }
        }

        private void LoadOrders()
        {
            try
            {
                var orders = _orderService.GetUserOrdersWithDetails(_currentUser.Id).ToList();

                var displayOrders = orders.Select(o => new
                {
                    o.Id,
                    o.UserId,
                    o.OrderDate,
                    ItemsCount = o.Details.Count,
                    o.Status,
                    o.TotalAmount,
                    OriginalOrder = o
                }).ToList();

                dataGridViewOrders.DataSource = displayOrders;

                dataGridViewOrders.Columns["Id"].Visible = false;
                dataGridViewOrders.Columns["UserId"].Visible = false;
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
            }
        }

        private void DataGridViewOrders_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null) return;

            var row = grid.Rows[e.RowIndex];
            var status = row.Cells["Status"].Value?.ToString();

            if (string.IsNullOrEmpty(status)) return;

            if (status.Equals("completed", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (status.Equals("cancelled", StringComparison.OrdinalIgnoreCase))
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = grid.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = grid.DefaultCellStyle.ForeColor;
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
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var selectedProducts = new List<Product>();
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells["Select"] is DataGridViewCheckBoxCell checkBox && checkBox.Value != null && (bool)checkBox.Value)
                {
                    selectedProducts.Add((Product)row.DataBoundItem);
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }

            if (selectedProducts.Count == 0)
            {
                FormHelper.ShowError("Пожалуйста, выберите хотя бы один товар");
                return;
            }

            using (var form = new OrderForm(selectedProducts, _currentUser.Id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var orderDetails = form.OrderDetails;
                    if (orderDetails == null || !orderDetails.Any())
                    {
                        FormHelper.ShowError("Не указаны детали заказа");
                        return;
                    }

                    decimal totalCost = orderDetails.Sum(d => d.UnitPrice * d.Quantity);

                    if (_userService.GetBalance(_currentUser.Id) < totalCost)
                    {
                        FormHelper.ShowError("Недостаточно средств на балансе для оформления заказа");
                        return;
                    }

                    try
                    {
                        _orderService.CreateOrder(_currentUser.Id, orderDetails);
                        _userService.AddBalance(_currentUser.Id, -totalCost);
                        FormHelper.ShowInfo("Заказ успешно создан");
                        LoadOrders();
                        LoadProducts();
                        lblBalanceValue.Text = $"{_userService.GetBalance(_currentUser.Id):F2} ₽";
                    }
                    catch (Exception ex)
                    {
                        FormHelper.ShowError(ex.Message);
                    }
                }
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
                    }
                    catch (Exception ex)
                    {
                        FormHelper.ShowError($"Ошибка при загрузке деталей заказа: {ex.Message}");
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTopUpBalance_Click(object sender, EventArgs e)
        {
            using (var form = new TopUpBalanceForm(_currentUser.Id, _userService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    lblBalanceValue.Text = $"{_userService.GetBalance(_currentUser.Id):F2} ₽";
                    FormHelper.ShowInfo("Баланс успешно пополнен");
                }
            }
        }
    }
}