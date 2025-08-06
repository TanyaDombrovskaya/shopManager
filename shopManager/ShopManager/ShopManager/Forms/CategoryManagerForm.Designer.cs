namespace ShopManager.Forms
{
    partial class CategoryManagerForm
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
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();

            // dataGridViewCategories
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(460, 200);
            this.dataGridViewCategories.TabIndex = 0;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.FromArgb(250, 250, 252); // Очень светлый фон
            this.dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewCategories.RowHeadersVisible = false;
            this.dataGridViewCategories.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(0, 102, 204), // Глубокий синий
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                SelectionBackColor = System.Drawing.Color.FromArgb(0, 102, 204),
                SelectionForeColor = System.Drawing.Color.White
            };
            this.dataGridViewCategories.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = System.Drawing.Color.FromArgb(50, 50, 50),
                SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255), // Мягкий синий при выборе
                SelectionForeColor = System.Drawing.Color.FromArgb(30, 30, 30)
            };
            this.dataGridViewCategories.EnableHeadersVisualStyles = false;

            // btnAddCategory
            this.btnAddCategory.Location = new System.Drawing.Point(20, 230);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(120, 40);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Добавить";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(102, 187, 106); // Мягкий зеленый
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.FlatAppearance.BorderSize = 1;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(85, 160, 90);
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(85, 160, 90);
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(70, 140, 75);
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);

            // btnEditCategory
            this.btnEditCategory.Location = new System.Drawing.Point(150, 230);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(120, 40);
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Редактировать";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(255, 202, 40); // Мягкий желтый
            this.btnEditCategory.ForeColor = System.Drawing.Color.Black;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.FlatAppearance.BorderSize = 1;
            this.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 175, 35);
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 175, 35);
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(200, 155, 30);
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);

            // btnDeleteCategory
            this.btnDeleteCategory.Location = new System.Drawing.Point(280, 230);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Удалить";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(239, 83, 80); // Мягкий красный
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 1;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(215, 70, 70);
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(215, 70, 70);
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 60, 60);
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);

            // CategoryManagerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 252); // Очень светлый фон
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dataGridViewCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление категориями";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoryManagerForm_Paint); // Градиентный фон
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;

        private void CategoryManagerForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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