namespace ShopManager.Forms
{
    partial class ProductForm
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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblStockQuantity = new Label();
            numStockQuantity = new NumericUpDown();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            btnSave = new Button();
            btnEditCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(27, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(69, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Товар";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(0, 102, 204);
            lblName.Location = new Point(27, 77);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Название";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(250, 250, 252);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.FromArgb(50, 50, 50);
            txtName.Location = new Point(27, 115);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(479, 30);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(0, 102, 204);
            lblDescription.Location = new Point(27, 169);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(250, 250, 252);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.FromArgb(50, 50, 50);
            txtDescription.Location = new Point(27, 208);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(479, 107);
            txtDescription.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.ForeColor = Color.FromArgb(0, 102, 204);
            lblPrice.Location = new Point(27, 331);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(51, 23);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Цена";
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.FromArgb(250, 250, 252);
            numPrice.BorderStyle = BorderStyle.FixedSingle;
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 10F);
            numPrice.ForeColor = Color.FromArgb(50, 50, 50);
            numPrice.Location = new Point(27, 369);
            numPrice.Margin = new Padding(4, 5, 4, 5);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(160, 30);
            numPrice.TabIndex = 6;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Segoe UI", 10F);
            lblStockQuantity.ForeColor = Color.FromArgb(0, 102, 204);
            lblStockQuantity.Location = new Point(213, 331);
            lblStockQuantity.Margin = new Padding(4, 0, 4, 0);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(102, 23);
            lblStockQuantity.TabIndex = 7;
            lblStockQuantity.Text = "Количество";
            // 
            // numStockQuantity
            // 
            numStockQuantity.BackColor = Color.FromArgb(250, 250, 252);
            numStockQuantity.BorderStyle = BorderStyle.FixedSingle;
            numStockQuantity.Font = new Font("Segoe UI", 10F);
            numStockQuantity.ForeColor = Color.FromArgb(50, 50, 50);
            numStockQuantity.Location = new Point(213, 369);
            numStockQuantity.Margin = new Padding(4, 5, 4, 5);
            numStockQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStockQuantity.Name = "numStockQuantity";
            numStockQuantity.Size = new Size(160, 30);
            numStockQuantity.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.ForeColor = Color.FromArgb(0, 102, 204);
            lblCategory.Location = new Point(27, 423);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 23);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Категория";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(250, 250, 252);
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.ForeColor = Color.FromArgb(50, 50, 50);
            cbCategory.Location = new Point(27, 462);
            cbCategory.Margin = new Padding(4, 5, 4, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(318, 31);
            cbCategory.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(102, 187, 106);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(373, 523);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 54);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEditCategories
            // 
            btnEditCategories.BackColor = Color.FromArgb(117, 117, 117);
            btnEditCategories.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnEditCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnEditCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            btnEditCategories.FlatStyle = FlatStyle.Flat;
            btnEditCategories.Font = new Font("Segoe UI", 9F);
            btnEditCategories.ForeColor = Color.White;
            btnEditCategories.Location = new Point(353, 458);
            btnEditCategories.Margin = new Padding(4, 5, 4, 5);
            btnEditCategories.Name = "btnEditCategories";
            btnEditCategories.Size = new Size(139, 38);
            btnEditCategories.TabIndex = 11;
            btnEditCategories.Text = "Редактировать";
            btnEditCategories.UseVisualStyleBackColor = false;
            btnEditCategories.Click += btnEditCategories_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(533, 600);
            Controls.Add(btnEditCategories);
            Controls.Add(btnSave);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(numStockQuantity);
            Controls.Add(lblStockQuantity);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование товара";
            Paint += ProductForm_Paint;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.NumericUpDown numStockQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditCategories;

        private void ProductForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.Color.FromArgb(255, 250, 250, 252),
                System.Drawing.Color.FromArgb(255, 240, 240, 248),
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}