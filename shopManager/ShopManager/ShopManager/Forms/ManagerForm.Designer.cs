namespace ShopManager.Forms
{
    partial class ManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblWelcome = new Label();
            tabControl = new TabControl();
            tabProducts = new TabPage();
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnRefresh = new Button();
            btnDeleteProduct = new Button();
            tabOrders = new TabPage();
            dataGridViewOrders = new DataGridView();
            dataGridViewOrderDetails = new DataGridView();
            btnUpdateOrderStatus = new Button();
            btnResetFilter = new Button();
            btnDeleteOrder = new Button();
            chkFilterByUser = new CheckBox();
            btnFilter = new Button();
            comboFilter = new ComboBox();
            chkFilterByStatus = new CheckBox();
            tabReports = new TabPage();
            btnSalesReport = new Button();
            btnInventoryReport = new Button();
            btnTopProducts = new Button();
            btnLogout = new Button();
            tabControl.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            tabReports.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 102, 204);
            lblWelcome.Location = new Point(40, 46);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 37);
            lblWelcome.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabProducts);
            tabControl.Controls.Add(tabOrders);
            tabControl.Controls.Add(tabReports);
            tabControl.Location = new Point(40, 123);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(987, 538);
            tabControl.TabIndex = 1;
            // 
            // tabProducts
            // 
            tabProducts.BackColor = Color.FromArgb(250, 250, 252);
            tabProducts.Controls.Add(dataGridViewProducts);
            tabProducts.Controls.Add(btnAddProduct);
            tabProducts.Controls.Add(btnEditProduct);
            tabProducts.Controls.Add(btnRefresh);
            tabProducts.Controls.Add(btnDeleteProduct);
            tabProducts.Location = new Point(4, 29);
            tabProducts.Margin = new Padding(4, 5, 4, 5);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(4, 5, 4, 5);
            tabProducts.Size = new Size(979, 505);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Товары";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.BackgroundColor = Color.FromArgb(250, 250, 252);
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.Location = new Point(13, 15);
            dataGridViewProducts.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(953, 350);
            dataGridViewProducts.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(102, 187, 106);
            btnAddProduct.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnAddProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnAddProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(13, 385);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(173, 62);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.FromArgb(255, 202, 40);
            btnEditProduct.FlatAppearance.BorderColor = Color.FromArgb(220, 175, 35);
            btnEditProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 155, 30);
            btnEditProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 175, 35);
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.ForeColor = Color.Black;
            btnEditProduct.Location = new Point(200, 385);
            btnEditProduct.Margin = new Padding(4, 5, 4, 5);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(173, 62);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Редактировать";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(66, 165, 245);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(574, 385);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(173, 62);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(239, 83, 80);
            btnDeleteProduct.FlatAppearance.BorderColor = Color.FromArgb(215, 70, 70);
            btnDeleteProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 60, 60);
            btnDeleteProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 70, 70);
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(387, 385);
            btnDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(173, 62);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Удалить";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // tabOrders
            // 
            tabOrders.BackColor = Color.FromArgb(250, 250, 252);
            tabOrders.Controls.Add(dataGridViewOrders);
            tabOrders.Controls.Add(dataGridViewOrderDetails);
            tabOrders.Controls.Add(btnUpdateOrderStatus);
            tabOrders.Controls.Add(btnResetFilter);
            tabOrders.Controls.Add(btnDeleteOrder);
            tabOrders.Controls.Add(chkFilterByUser);
            tabOrders.Controls.Add(btnFilter);
            tabOrders.Controls.Add(comboFilter);
            tabOrders.Controls.Add(chkFilterByStatus);
            tabOrders.Location = new Point(4, 29);
            tabOrders.Margin = new Padding(4, 5, 4, 5);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(4, 5, 4, 5);
            tabOrders.Size = new Size(979, 505);
            tabOrders.TabIndex = 1;
            tabOrders.Text = "Заказы";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.BackgroundColor = Color.FromArgb(250, 250, 252);
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.EnableHeadersVisualStyles = false;
            dataGridViewOrders.Location = new Point(13, 15);
            dataGridViewOrders.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(953, 200);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.AllowUserToAddRows = false;
            dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            dataGridViewOrderDetails.BackgroundColor = Color.FromArgb(250, 250, 252);
            dataGridViewOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            dataGridViewOrderDetails.Location = new Point(13, 225);
            dataGridViewOrderDetails.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.ReadOnly = true;
            dataGridViewOrderDetails.RowHeadersVisible = false;
            dataGridViewOrderDetails.RowHeadersWidth = 51;
            dataGridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderDetails.Size = new Size(953, 150);
            dataGridViewOrderDetails.TabIndex = 1;
            // 
            // btnUpdateOrderStatus
            // 
            btnUpdateOrderStatus.BackColor = Color.FromArgb(255, 202, 40);
            btnUpdateOrderStatus.FlatAppearance.BorderColor = Color.FromArgb(220, 175, 35);
            btnUpdateOrderStatus.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 155, 30);
            btnUpdateOrderStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 175, 35);
            btnUpdateOrderStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateOrderStatus.ForeColor = Color.Black;
            btnUpdateOrderStatus.Location = new Point(13, 400);
            btnUpdateOrderStatus.Margin = new Padding(4, 5, 4, 5);
            btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            btnUpdateOrderStatus.Size = new Size(146, 62);
            btnUpdateOrderStatus.TabIndex = 2;
            btnUpdateOrderStatus.Text = "Изменить статус";
            btnUpdateOrderStatus.UseVisualStyleBackColor = false;
            btnUpdateOrderStatus.Click += btnUpdateOrderStatus_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.FromArgb(117, 117, 117);
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnResetFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnResetFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(810, 400);
            btnResetFilter.Margin = new Padding(4, 5, 4, 5);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(151, 62);
            btnResetFilter.TabIndex = 8;
            btnResetFilter.Text = "Сбросить фильтр";
            btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.FromArgb(239, 83, 80);
            btnDeleteOrder.FlatAppearance.BorderColor = Color.FromArgb(215, 70, 70);
            btnDeleteOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 60, 60);
            btnDeleteOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 70, 70);
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(167, 400);
            btnDeleteOrder.Margin = new Padding(4, 5, 4, 5);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(149, 62);
            btnDeleteOrder.TabIndex = 3;
            btnDeleteOrder.Text = "Удалить заказ";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // chkFilterByUser
            // 
            chkFilterByUser.AutoSize = true;
            chkFilterByUser.Location = new Point(324, 400);
            chkFilterByUser.Margin = new Padding(4, 5, 4, 5);
            chkFilterByUser.Name = "chkFilterByUser";
            chkFilterByUser.Size = new Size(215, 24);
            chkFilterByUser.TabIndex = 4;
            chkFilterByUser.Text = "Фильтр по пользователям";
            chkFilterByUser.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(66, 165, 245);
            btnFilter.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(679, 400);
            btnFilter.Margin = new Padding(4, 5, 4, 5);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(123, 62);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Фильтровать";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // comboFilter
            // 
            comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilter.FlatStyle = FlatStyle.Flat;
            comboFilter.FormattingEnabled = true;
            comboFilter.Location = new Point(542, 418);
            comboFilter.Margin = new Padding(4, 5, 4, 5);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(129, 28);
            comboFilter.TabIndex = 6;
            // 
            // chkFilterByStatus
            // 
            chkFilterByStatus.AutoSize = true;
            chkFilterByStatus.Location = new Point(324, 432);
            chkFilterByStatus.Margin = new Padding(4, 5, 4, 5);
            chkFilterByStatus.Name = "chkFilterByStatus";
            chkFilterByStatus.Size = new Size(156, 24);
            chkFilterByStatus.TabIndex = 5;
            chkFilterByStatus.Text = "Фильтр по статусу";
            chkFilterByStatus.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.BackColor = Color.FromArgb(250, 250, 252);
            tabReports.Controls.Add(btnSalesReport);
            tabReports.Controls.Add(btnInventoryReport);
            tabReports.Controls.Add(btnTopProducts);
            tabReports.Location = new Point(4, 29);
            tabReports.Margin = new Padding(4, 5, 4, 5);
            tabReports.Name = "tabReports";
            tabReports.Padding = new Padding(4, 5, 4, 5);
            tabReports.Size = new Size(979, 505);
            tabReports.TabIndex = 2;
            tabReports.Text = "Отчеты";
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.FromArgb(66, 165, 245);
            btnSalesReport.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnSalesReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnSalesReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnSalesReport.FlatStyle = FlatStyle.Flat;
            btnSalesReport.ForeColor = Color.White;
            btnSalesReport.Location = new Point(27, 31);
            btnSalesReport.Margin = new Padding(4, 5, 4, 5);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(267, 62);
            btnSalesReport.TabIndex = 0;
            btnSalesReport.Text = "Отчет о продажах";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnInventoryReport
            // 
            btnInventoryReport.BackColor = Color.FromArgb(66, 165, 245);
            btnInventoryReport.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnInventoryReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnInventoryReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnInventoryReport.FlatStyle = FlatStyle.Flat;
            btnInventoryReport.ForeColor = Color.White;
            btnInventoryReport.Location = new Point(27, 123);
            btnInventoryReport.Margin = new Padding(4, 5, 4, 5);
            btnInventoryReport.Name = "btnInventoryReport";
            btnInventoryReport.Size = new Size(267, 62);
            btnInventoryReport.TabIndex = 1;
            btnInventoryReport.Text = "Отчет по инвентаризации";
            btnInventoryReport.UseVisualStyleBackColor = false;
            btnInventoryReport.Click += btnInventoryReport_Click;
            // 
            // btnTopProducts
            // 
            btnTopProducts.BackColor = Color.FromArgb(66, 165, 245);
            btnTopProducts.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnTopProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnTopProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnTopProducts.FlatStyle = FlatStyle.Flat;
            btnTopProducts.ForeColor = Color.White;
            btnTopProducts.Location = new Point(27, 215);
            btnTopProducts.Margin = new Padding(4, 5, 4, 5);
            btnTopProducts.Name = "btnTopProducts";
            btnTopProducts.Size = new Size(267, 62);
            btnTopProducts.TabIndex = 2;
            btnTopProducts.Text = "Топ продаваемых товаров";
            btnTopProducts.UseVisualStyleBackColor = false;
            btnTopProducts.Click += btnTopProducts_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(117, 117, 117);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(854, 692);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 62);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(1071, 785);
            Controls.Add(btnLogout);
            Controls.Add(tabControl);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Панель менеджера";
            tabControl.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabOrders.ResumeLayout(false);
            tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            tabReports.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnResetFilter;

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.CheckBox chkFilterByUser;
        private System.Windows.Forms.CheckBox chkFilterByStatus;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Button btnTopProducts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
    }
}