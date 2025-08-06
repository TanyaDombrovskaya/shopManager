namespace ShopManager.Forms
{
    partial class OrderForm
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
            numQuantity = new NumericUpDown();
            lblTotalAmount = new Label();
            btnAddToOrder = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
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
            lblTitle.Size = new Size(0, 28);
            lblTitle.TabIndex = 0;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = Color.FromArgb(250, 250, 252);
            numQuantity.BorderStyle = BorderStyle.FixedSingle;
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.ForeColor = Color.FromArgb(50, 50, 50);
            numQuantity.Location = new Point(27, 272);
            numQuantity.Margin = new Padding(4, 5, 4, 5);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(160, 30);
            numQuantity.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(0, 102, 204);
            lblTotalAmount.Location = new Point(27, 154);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 23);
            lblTotalAmount.TabIndex = 2;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.BackColor = Color.FromArgb(102, 187, 106);
            btnAddToOrder.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnAddToOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnAddToOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnAddToOrder.FlatStyle = FlatStyle.Flat;
            btnAddToOrder.ForeColor = Color.White;
            btnAddToOrder.Location = new Point(213, 259);
            btnAddToOrder.Margin = new Padding(4, 5, 4, 5);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(200, 54);
            btnAddToOrder.TabIndex = 3;
            btnAddToOrder.Text = "Добавить в заказ";
            btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(102, 187, 106);
            btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(253, 335);
            btnConfirm.Margin = new Padding(4, 5, 4, 5);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(160, 57);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Оформить";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(451, 416);
            Controls.Add(btnConfirm);
            Controls.Add(btnAddToOrder);
            Controls.Add(lblTotalAmount);
            Controls.Add(numQuantity);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформление заказа";
            Paint += OrderForm_Paint;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnConfirm;

        private void OrderForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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