namespace ShopManager.Forms
{
    partial class DateRangeForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204); // Глубокий синий
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(140, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Выбор периода";

            // lblStartDate
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204); // Глубокий синий
            this.lblStartDate.Location = new System.Drawing.Point(20, 60);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new Size(90, 17);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Дата начала";

            // dtpStartDate
            this.dtpStartDate.Location = new System.Drawing.Point(20, 85);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(260, 25);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);

            // lblEndDate
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204); // Глубокий синий
            this.lblEndDate.Location = new System.Drawing.Point(20, 120);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new Size(130, 17);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "Дата окончания";

            // dtpEndDate
            this.dtpEndDate.Location = new System.Drawing.Point(20, 145);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(260, 25);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);

            // btnGenerate
            this.btnGenerate.Location = new System.Drawing.Point(180, 185);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 40);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Сформировать";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(102, 187, 106); // Мягкий зеленый
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 1;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(85, 160, 90);
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(85, 160, 90);
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(70, 140, 75);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // DateRangeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 252); // Очень светлый фон
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DateRangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор периода для отчета";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DateRangeForm_Paint); // Градиентный фон
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGenerate;

        private void DateRangeForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.Color.FromArgb(255, 250, 250, 252), // Начальный цвет
                System.Drawing.Color.FromArgb(255, 240, 240, 248), // Конечный цвет
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}