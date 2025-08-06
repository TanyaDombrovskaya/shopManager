namespace ShopManager.Forms
{
    partial class UserForm
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
            btnCreateOrder = new Button();
            btnRefreshProducts = new Button();
            tabOrders = new TabPage();
            dataGridViewOrders = new DataGridView();
            dataGridViewOrderDetails = new DataGridView();
            btnLogout = new Button();
            lblBalance = new Label();
            lblBalanceValue = new Label();
            btnTopUpBalance = new Button();
            tabControl.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
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
            tabProducts.Controls.Add(btnCreateOrder);
            tabProducts.Controls.Add(btnRefreshProducts);
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
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.FromArgb(102, 187, 106);
            btnCreateOrder.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnCreateOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnCreateOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Location = new Point(13, 415);
            btnCreateOrder.Margin = new Padding(4, 5, 4, 5);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(200, 62);
            btnCreateOrder.TabIndex = 1;
            btnCreateOrder.Text = "Оформить заказ";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.BackColor = Color.FromArgb(66, 165, 245);
            btnRefreshProducts.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnRefreshProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnRefreshProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnRefreshProducts.FlatStyle = FlatStyle.Flat;
            btnRefreshProducts.ForeColor = Color.White;
            btnRefreshProducts.Location = new Point(221, 415);
            btnRefreshProducts.Margin = new Padding(4, 5, 4, 5);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(173, 62);
            btnRefreshProducts.TabIndex = 3;
            btnRefreshProducts.Text = "Обновить";
            btnRefreshProducts.UseVisualStyleBackColor = false;
            // 
            // tabOrders
            // 
            tabOrders.BackColor = Color.FromArgb(250, 250, 252);
            tabOrders.Controls.Add(dataGridViewOrders);
            tabOrders.Controls.Add(dataGridViewOrderDetails);
            tabOrders.Location = new Point(4, 29);
            tabOrders.Margin = new Padding(4, 5, 4, 5);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(4, 5, 4, 5);
            tabOrders.Size = new Size(979, 505);
            tabOrders.TabIndex = 1;
            tabOrders.Text = "Мои заказы";
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
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10F);
            lblBalance.Location = new Point(617, 56);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(69, 23);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Баланс:";
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBalanceValue.Location = new Point(702, 56);
            lblBalanceValue.Name = "lblBalanceValue";
            lblBalanceValue.Size = new Size(60, 23);
            lblBalanceValue.TabIndex = 4;
            lblBalanceValue.Text = "0.00 ₽";
            // 
            // btnTopUpBalance
            // 
            btnTopUpBalance.BackColor = Color.FromArgb(66, 165, 245);
            btnTopUpBalance.FlatAppearance.BorderColor = Color.FromArgb(50, 145, 230);
            btnTopUpBalance.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 130, 210);
            btnTopUpBalance.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 145, 230);
            btnTopUpBalance.FlatStyle = FlatStyle.Flat;
            btnTopUpBalance.ForeColor = Color.White;
            btnTopUpBalance.Location = new Point(854, 46);
            btnTopUpBalance.Margin = new Padding(4, 5, 4, 5);
            btnTopUpBalance.Name = "btnTopUpBalance";
            btnTopUpBalance.Size = new Size(173, 46);
            btnTopUpBalance.TabIndex = 5;
            btnTopUpBalance.Text = "Пополнить баланс";
            btnTopUpBalance.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(1071, 785);
            Controls.Add(btnTopUpBalance);
            Controls.Add(lblBalanceValue);
            Controls.Add(lblBalance);
            Controls.Add(btnLogout);
            Controls.Add(tabControl);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Панель пользователя";
            tabControl.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Button btnLogout;
        private Label lblBalance;
        private Label lblBalanceValue;
        private Button btnTopUpBalance;
        private Button btnRefreshProducts;
    }
}