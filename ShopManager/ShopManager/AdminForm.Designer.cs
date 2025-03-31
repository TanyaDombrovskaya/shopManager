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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            infoPanel = new Panel();
            valueLabel = new Label();
            label6 = new Label();
            colIndexLabel = new Label();
            rowIndexLabel = new Label();
            tableNameLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dbTable = new DataGridView();
            panelUpAdmin.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            settingsPanel.SuspendLayout();
            dbPanel.SuspendLayout();
            infoPanel.SuspendLayout();
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
            mainPanel.Size = new Size(221, 731);
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
            settingsButton.Size = new Size(221, 68);
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
            detailsButtons.Size = new Size(221, 68);
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
            orderButton.Size = new Size(221, 68);
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
            categoriesButton.Size = new Size(221, 68);
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
            productsButton.Size = new Size(221, 68);
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
            usersButton.Size = new Size(221, 68);
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
            settingsPanel.Location = new Point(221, 59);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(836, 731);
            settingsPanel.TabIndex = 14;
            settingsPanel.Visible = false;
            // 
            // dbPanel
            // 
            dbPanel.Controls.Add(infoPanel);
            dbPanel.Controls.Add(dbTable);
            dbPanel.Dock = DockStyle.Fill;
            dbPanel.Location = new Point(0, 0);
            dbPanel.Name = "dbPanel";
            dbPanel.Size = new Size(836, 731);
            dbPanel.TabIndex = 7;
            dbPanel.Visible = false;
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.None;
            infoPanel.BackColor = Color.Teal;
            infoPanel.Controls.Add(valueLabel);
            infoPanel.Controls.Add(label6);
            infoPanel.Controls.Add(colIndexLabel);
            infoPanel.Controls.Add(rowIndexLabel);
            infoPanel.Controls.Add(tableNameLabel);
            infoPanel.Controls.Add(label3);
            infoPanel.Controls.Add(label2);
            infoPanel.Controls.Add(label1);
            infoPanel.Location = new Point(0, 424);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(856, 350);
            infoPanel.TabIndex = 1;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            valueLabel.ForeColor = Color.White;
            valueLabel.Location = new Point(137, 108);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(0, 28);
            valueLabel.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 108);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 17;
            label6.Text = "Значение: ";
            // 
            // colIndexLabel
            // 
            colIndexLabel.AutoSize = true;
            colIndexLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            colIndexLabel.ForeColor = Color.White;
            colIndexLabel.Location = new Point(122, 52);
            colIndexLabel.Name = "colIndexLabel";
            colIndexLabel.Size = new Size(24, 28);
            colIndexLabel.TabIndex = 16;
            colIndexLabel.Text = "1";
            // 
            // rowIndexLabel
            // 
            rowIndexLabel.AutoSize = true;
            rowIndexLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rowIndexLabel.ForeColor = Color.White;
            rowIndexLabel.Location = new Point(108, 80);
            rowIndexLabel.Name = "rowIndexLabel";
            rowIndexLabel.Size = new Size(24, 28);
            rowIndexLabel.TabIndex = 15;
            rowIndexLabel.Text = "1";
            // 
            // tableNameLabel
            // 
            tableNameLabel.AutoSize = true;
            tableNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableNameLabel.ForeColor = Color.White;
            tableNameLabel.Location = new Point(127, 24);
            tableNameLabel.Name = "tableNameLabel";
            tableNameLabel.Size = new Size(0, 28);
            tableNameLabel.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 13;
            label3.Text = "Строка: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 52);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 12;
            label2.Text = "Столбец: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 11;
            label1.Text = "Таблица: ";
            // 
            // dbTable
            // 
            dbTable.AllowUserToAddRows = false;
            dbTable.AllowUserToDeleteRows = false;
            dbTable.Anchor = AnchorStyles.None;
            dbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbTable.BackgroundColor = Color.LightCyan;
            dbTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dbTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dbTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dbTable.DefaultCellStyle = dataGridViewCellStyle2;
            dbTable.EnableHeadersVisualStyles = false;
            dbTable.Location = new Point(35, 68);
            dbTable.Name = "dbTable";
            dbTable.ReadOnly = true;
            dbTable.RowHeadersWidth = 51;
            dbTable.Size = new Size(778, 329);
            dbTable.TabIndex = 0;
            dbTable.CellClick += dbTable_CellClick;
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
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
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
        private Panel infoPanel;
        private Label label1;
        private Label tableNameLabel;
        private Label label3;
        private Label label2;
        private Label colIndexLabel;
        private Label rowIndexLabel;
        private Label valueLabel;
        private Label label6;
    }
}