namespace ShopManager
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            closeButton = new Label();
            adminLabel = new Label();
            nameAdmin = new Label();
            panelUpAdmin = new Panel();
            mainPanel = new Panel();
            settingsButton = new Button();
            detailsButtons = new Button();
            orderButton = new Button();
            categoriesButton = new Button();
            productsButton = new Button();
            usersButton = new Button();
            panel1 = new Panel();
            zaprosButton = new Button();
            filterButton = new Button();
            sortButton = new Button();
            exitButton = new Button();
            settingsPanel = new Panel();
            dbPanel = new Panel();
            dbTable = new DataGridView();
            panelUpAdmin.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            settingsPanel.SuspendLayout();
            dbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbTable).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.FromArgb(192, 0, 0);
            closeButton.Location = new Point(1221, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 31);
            closeButton.TabIndex = 8;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            adminLabel.ForeColor = Color.White;
            adminLabel.Location = new Point(35, 14);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(168, 28);
            adminLabel.TabIndex = 9;
            adminLabel.Text = "Администратор";
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameAdmin.ForeColor = Color.White;
            nameAdmin.Location = new Point(203, 14);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(126, 28);
            nameAdmin.TabIndex = 10;
            nameAdmin.Text = "nameAdmin";
            // 
            // panelUpAdmin
            // 
            panelUpAdmin.BackColor = Color.Teal;
            panelUpAdmin.Controls.Add(adminLabel);
            panelUpAdmin.Controls.Add(closeButton);
            panelUpAdmin.Controls.Add(nameAdmin);
            panelUpAdmin.Dock = DockStyle.Top;
            panelUpAdmin.Location = new Point(0, 0);
            panelUpAdmin.Name = "panelUpAdmin";
            panelUpAdmin.Size = new Size(1263, 59);
            panelUpAdmin.TabIndex = 11;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(99, 164, 191);
            mainPanel.Controls.Add(settingsButton);
            mainPanel.Controls.Add(detailsButtons);
            mainPanel.Controls.Add(orderButton);
            mainPanel.Controls.Add(categoriesButton);
            mainPanel.Controls.Add(productsButton);
            mainPanel.Controls.Add(usersButton);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 59);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(228, 731);
            mainPanel.TabIndex = 12;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(26, 155, 131);
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.Dock = DockStyle.Top;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(0, 340);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(228, 68);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // detailsButtons
            // 
            detailsButtons.BackColor = Color.FromArgb(26, 155, 131);
            detailsButtons.Cursor = Cursors.Hand;
            detailsButtons.Dock = DockStyle.Top;
            detailsButtons.FlatStyle = FlatStyle.Flat;
            detailsButtons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            detailsButtons.ForeColor = Color.White;
            detailsButtons.Location = new Point(0, 272);
            detailsButtons.Name = "detailsButtons";
            detailsButtons.Size = new Size(228, 68);
            detailsButtons.TabIndex = 4;
            detailsButtons.Text = "Детали заказов";
            detailsButtons.UseVisualStyleBackColor = false;
            detailsButtons.Click += detailsButtons_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(26, 155, 131);
            orderButton.Cursor = Cursors.Hand;
            orderButton.Dock = DockStyle.Top;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(0, 204);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(228, 68);
            orderButton.TabIndex = 3;
            orderButton.Text = "Заказы";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // categoriesButton
            // 
            categoriesButton.BackColor = Color.FromArgb(26, 155, 131);
            categoriesButton.Cursor = Cursors.Hand;
            categoriesButton.Dock = DockStyle.Top;
            categoriesButton.FlatStyle = FlatStyle.Flat;
            categoriesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            categoriesButton.ForeColor = Color.White;
            categoriesButton.Location = new Point(0, 136);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(228, 68);
            categoriesButton.TabIndex = 2;
            categoriesButton.Text = "Категории";
            categoriesButton.UseVisualStyleBackColor = false;
            categoriesButton.Click += categoriesButton_Click;
            // 
            // productsButton
            // 
            productsButton.BackColor = Color.FromArgb(26, 155, 131);
            productsButton.Cursor = Cursors.Hand;
            productsButton.Dock = DockStyle.Top;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productsButton.ForeColor = Color.White;
            productsButton.Location = new Point(0, 68);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(228, 68);
            productsButton.TabIndex = 1;
            productsButton.Text = "Товар";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // usersButton
            // 
            usersButton.BackColor = Color.FromArgb(26, 155, 131);
            usersButton.Cursor = Cursors.Hand;
            usersButton.Dock = DockStyle.Top;
            usersButton.FlatStyle = FlatStyle.Flat;
            usersButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            usersButton.ForeColor = Color.White;
            usersButton.Location = new Point(0, 0);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(228, 68);
            usersButton.TabIndex = 0;
            usersButton.Text = "Пользователи";
            usersButton.UseVisualStyleBackColor = false;
            usersButton.Click += usersButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(99, 164, 191);
            panel1.Controls.Add(zaprosButton);
            panel1.Controls.Add(filterButton);
            panel1.Controls.Add(sortButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1057, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 731);
            panel1.TabIndex = 13;
            // 
            // zaprosButton
            // 
            zaprosButton.BackColor = Color.FromArgb(26, 155, 131);
            zaprosButton.Cursor = Cursors.Hand;
            zaprosButton.Dock = DockStyle.Top;
            zaprosButton.FlatStyle = FlatStyle.Flat;
            zaprosButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            zaprosButton.ForeColor = Color.White;
            zaprosButton.Location = new Point(0, 136);
            zaprosButton.Name = "zaprosButton";
            zaprosButton.Size = new Size(206, 68);
            zaprosButton.TabIndex = 3;
            zaprosButton.Text = "Запрос";
            zaprosButton.UseVisualStyleBackColor = false;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(26, 155, 131);
            filterButton.Cursor = Cursors.Hand;
            filterButton.Dock = DockStyle.Top;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(0, 68);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(206, 68);
            filterButton.TabIndex = 2;
            filterButton.Text = "Фильрация";
            filterButton.UseVisualStyleBackColor = false;
            // 
            // sortButton
            // 
            sortButton.BackColor = Color.FromArgb(26, 155, 131);
            sortButton.Cursor = Cursors.Hand;
            sortButton.Dock = DockStyle.Top;
            sortButton.FlatStyle = FlatStyle.Flat;
            sortButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sortButton.ForeColor = Color.White;
            sortButton.Location = new Point(0, 0);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(206, 68);
            sortButton.TabIndex = 1;
            sortButton.Text = "Сортировка";
            sortButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(192, 0, 0);
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(324, 568);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(228, 68);
            exitButton.TabIndex = 6;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(dbPanel);
            settingsPanel.Controls.Add(exitButton);
            settingsPanel.Dock = DockStyle.Fill;
            settingsPanel.Location = new Point(228, 59);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(829, 731);
            settingsPanel.TabIndex = 14;
            settingsPanel.Visible = false;
            // 
            // dbPanel
            // 
            dbPanel.Controls.Add(dbTable);
            dbPanel.Dock = DockStyle.Fill;
            dbPanel.Location = new Point(0, 0);
            dbPanel.Name = "dbPanel";
            dbPanel.Size = new Size(829, 731);
            dbPanel.TabIndex = 7;
            dbPanel.Visible = false;
            // 
            // dbTable
            // 
            dbTable.AllowUserToAddRows = false;
            dbTable.AllowUserToDeleteRows = false;
            dbTable.Anchor = AnchorStyles.None;
            dbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbTable.BackgroundColor = Color.LightCyan;
            dbTable.BorderStyle = BorderStyle.None;
            dbTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbTable.Location = new Point(43, 68);
            dbTable.Name = "dbTable";
            dbTable.ReadOnly = true;
            dbTable.RowHeadersWidth = 51;
            dbTable.Size = new Size(745, 329);
            dbTable.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1263, 790);
            Controls.Add(settingsPanel);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Controls.Add(panelUpAdmin);
            Name = "AdminForm";
            Text = "AdminForm";
            panelUpAdmin.ResumeLayout(false);
            panelUpAdmin.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            dbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label closeButton;
        private Label adminLabel;
        private Label nameAdmin;
        private Panel panelUpAdmin;
        private Panel mainPanel;
        private Button usersButton;
        private Button settingsButton;
        private Button detailsButtons;
        private Button orderButton;
        private Button categoriesButton;
        private Button productsButton;
        private Panel panel1;
        private Button sortButton;
        private Button zaprosButton;
        private Button filterButton;
        private Button exitButton;
        private Panel settingsPanel;
        private Panel dbPanel;
        private DataGridView dbTable;
    }
}