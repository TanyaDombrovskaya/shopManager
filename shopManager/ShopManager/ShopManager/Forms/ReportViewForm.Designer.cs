namespace ShopManager.Forms
{
    partial class ReportViewForm
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
            dataGridViewReport = new DataGridView();
            lblTitle = new Label();
            allPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.AllowUserToDeleteRows = false;
            dataGridViewReport.BackgroundColor = Color.FromArgb(250, 250, 252);
            dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.EnableHeadersVisualStyles = false;
            dataGridViewReport.Location = new Point(40, 123);
            dataGridViewReport.Margin = new Padding(4, 5, 4, 5);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.RowHeadersVisible = false;
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.Size = new Size(987, 538);
            dataGridViewReport.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(40, 692);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Итого:";
            // 
            // allPrice
            // 
            allPrice.AutoSize = true;
            allPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            allPrice.ForeColor = Color.FromArgb(0, 102, 204);
            allPrice.Location = new Point(854, 692);
            allPrice.Margin = new Padding(4, 0, 4, 0);
            allPrice.Name = "allPrice";
            allPrice.Size = new Size(33, 37);
            allPrice.TabIndex = 2;
            allPrice.Text = "0";
            // 
            // ReportViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(1071, 785);
            Controls.Add(allPrice);
            Controls.Add(lblTitle);
            Controls.Add(dataGridViewReport);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReportViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчет";
            Paint += ReportViewForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReport;
        private Label lblTitle;
        private Label allPrice;

        private void ReportViewForm_Paint(object sender, PaintEventArgs e)
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