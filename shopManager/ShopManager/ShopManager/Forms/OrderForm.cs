using ShopManager.Data.Models;
using ShopManager.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopManager.Forms
{
    public partial class OrderForm : Form
    {
        public List<OrderDetail> OrderDetails { get; private set; }
        private readonly List<Product> _products;
        private readonly int _userId;
        private List<RadioButton> radioButtons;

        public OrderForm(List<Product> products, int userId)
        {
            InitializeComponent();
            _products = products;
            _userId = userId;
            OrderDetails = new List<OrderDetail>();
            btnAddToOrder.Click += btnAddToOrder_Click;
            btnConfirm.Click += btnConfirm_Click;
            SetupControls();
        }

        private void SetupControls()
        {
            lblTitle.Text = "Оформление заказа";

            Panel productsPanel = new Panel
            {
                Location = new Point(20, 50),
                Size = new Size(400, 200),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(productsPanel);

            radioButtons = new List<RadioButton>();
            int yOffset = 10;

            foreach (var product in _products)
            {
                RadioButton radioButton = new RadioButton
                {
                    Location = new Point(10, yOffset),
                    Size = new Size(380, 20),
                    Text = $"{product.Name} - {product.Price:F2} ₽",
                    Tag = product
                };
                radioButton.Click += RadioButton_Click;
                productsPanel.Controls.Add(radioButton);
                radioButtons.Add(radioButton);
                yOffset += 25;
            }

            lblTotalAmount.Location = new Point(20, productsPanel.Bottom + 20);
            numQuantity.Location = new Point(20, lblTotalAmount.Bottom + 20);
            btnAddToOrder.Location = new Point(200, lblTotalAmount.Bottom + 15);
            btnConfirm.Location = new Point(20, numQuantity.Bottom + 20);

            this.ClientSize = new Size(450, btnConfirm.Bottom + 30);
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var selectedRadio = sender as RadioButton;
            if (selectedRadio != null)
            {
                var product = selectedRadio.Tag as Product;
                if (product != null)
                {
                    numQuantity.Maximum = product.StockQuantity;
                    numQuantity.Value = 0;
                }
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            var selectedRadio = radioButtons.Find(rb => rb.Checked);
            if (selectedRadio == null)
            {
                FormHelper.ShowError("Выберите товар");
                return;
            }

            var product = selectedRadio.Tag as Product;
            if (product == null)
            {
                FormHelper.ShowError("Ошибка при выборе товара");
                return;
            }

            if (numQuantity.Value == 0 || numQuantity.Value > product.StockQuantity)
            {
                FormHelper.ShowError("Укажите количество, не превышающее запас товара");
                return;
            }

            OrderDetails.Add(new OrderDetail
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = (int)numQuantity.Value,
                UnitPrice = product.Price
            });

            selectedRadio.Checked = false;
            numQuantity.Value = 0;
            UpdateTotalAmount();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderDetails.Count == 0)
                {
                    FormHelper.ShowError("Добавьте хотя бы один товар в заказ");
                    return;
                }

                foreach (var detail in OrderDetails)
                {
                    if (detail.Quantity == 0)
                    {
                        FormHelper.ShowError("Выберите количество для всех товаров");
                        return;
                    }
                }

                decimal totalCost = OrderDetails.Sum(d => d.UnitPrice * d.Quantity);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void UpdateTotalAmount()
        {
            decimal total = OrderDetails.Sum(d => d.UnitPrice * d.Quantity);
            lblTotalAmount.Text = $"Общая сумма: {total:F2} ₽";
        }
    }
}