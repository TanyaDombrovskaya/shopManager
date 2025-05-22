namespace ShopManager
{
    partial class ManagerForm
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
            nameManager = new Label();
            panelUpAdmin = new Panel();
            mainPanel = new Panel();
            exitButton = new Button();
            detailsButtons = new Button();
            orderButton = new Button();
            categoriesButton = new Button();
            productsButton = new Button();
            panel1 = new Panel();
            zaprosButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            dbPanel = new Panel();
            infoPanel = new Panel();
            rebootTable = new Label();
            settingsPanel = new Panel();
            delRowsButton = new Button();
            rowsIdBox = new ComboBox();
            hideSetPanel = new Label();
            changeButtonEnd = new Button();
            valueInput = new TextBox();
            changeValueButton = new Button();
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
            dbPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            settingsPanel.SuspendLayout();
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
            adminLabel.Size = new Size(117, 28);
            adminLabel.TabIndex = 9;
            adminLabel.Text = "Менеджер";
            // 
            // nameManager
            // 
            nameManager.AutoSize = true;
            nameManager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameManager.ForeColor = Color.White;
            nameManager.Location = new Point(158, 15);
            nameManager.Name = "nameManager";
            nameManager.Size = new Size(148, 28);
            nameManager.TabIndex = 10;
            nameManager.Text = "nameManager";
            // 
            // panelUpAdmin
            // 
            panelUpAdmin.BackColor = Color.Teal;
            panelUpAdmin.Controls.Add(adminLabel);
            panelUpAdmin.Controls.Add(closeButton);
            panelUpAdmin.Controls.Add(nameManager);
            panelUpAdmin.Dock = DockStyle.Top;
            panelUpAdmin.Location = new Point(0, 0);
            panelUpAdmin.Name = "panelUpAdmin";
            panelUpAdmin.Size = new Size(1263, 59);
            panelUpAdmin.TabIndex = 11;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(99, 164, 191);
            mainPanel.Controls.Add(exitButton);
            mainPanel.Controls.Add(detailsButtons);
            mainPanel.Controls.Add(orderButton);
            mainPanel.Controls.Add(categoriesButton);
            mainPanel.Controls.Add(productsButton);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 59);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(221, 731);
            mainPanel.TabIndex = 12;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(26, 155, 131);
            exitButton.Cursor = Cursors.Hand;
            exitButton.Dock = DockStyle.Top;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 272);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(221, 68);
            exitButton.TabIndex = 6;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // detailsButtons
            // 
            detailsButtons.BackColor = Color.FromArgb(26, 155, 131);
            detailsButtons.Cursor = Cursors.Hand;
            detailsButtons.Dock = DockStyle.Top;
            detailsButtons.FlatStyle = FlatStyle.Flat;
            detailsButtons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            detailsButtons.ForeColor = Color.White;
            detailsButtons.Location = new Point(0, 204);
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
            orderButton.Location = new Point(0, 136);
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
            categoriesButton.Location = new Point(0, 68);
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
            productsButton.Location = new Point(0, 0);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(221, 68);
            productsButton.TabIndex = 1;
            productsButton.Text = "Товар";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(99, 164, 191);
            panel1.Controls.Add(zaprosButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(addButton);
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
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(26, 155, 131);
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Dock = DockStyle.Top;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(0, 68);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(206, 68);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(26, 155, 131);
            addButton.Cursor = Cursors.Hand;
            addButton.Dock = DockStyle.Top;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(206, 68);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // dbPanel
            // 
            dbPanel.Controls.Add(infoPanel);
            dbPanel.Controls.Add(dbTable);
            dbPanel.Dock = DockStyle.Fill;
            dbPanel.Location = new Point(221, 59);
            dbPanel.Name = "dbPanel";
            dbPanel.Size = new Size(836, 731);
            dbPanel.TabIndex = 14;
            dbPanel.Visible = false;
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.None;
            infoPanel.BackColor = Color.Teal;
            infoPanel.Controls.Add(rebootTable);
            infoPanel.Controls.Add(settingsPanel);
            infoPanel.Controls.Add(changeValueButton);
            infoPanel.Controls.Add(valueLabel);
            infoPanel.Controls.Add(label6);
            infoPanel.Controls.Add(colIndexLabel);
            infoPanel.Controls.Add(rowIndexLabel);
            infoPanel.Controls.Add(tableNameLabel);
            infoPanel.Controls.Add(label3);
            infoPanel.Controls.Add(label2);
            infoPanel.Controls.Add(label1);
            infoPanel.Location = new Point(0, 391);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(856, 350);
            infoPanel.TabIndex = 1;
            // 
            // rebootTable
            // 
            rebootTable.AutoSize = true;
            rebootTable.Cursor = Cursors.Hand;
            rebootTable.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rebootTable.ForeColor = Color.FromArgb(192, 0, 0);
            rebootTable.Location = new Point(22, 271);
            rebootTable.Name = "rebootTable";
            rebootTable.Size = new Size(63, 60);
            rebootTable.TabIndex = 23;
            rebootTable.Text = "↺";
            rebootTable.Click += rebootTable_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.BackColor = Color.FromArgb(99, 164, 191);
            settingsPanel.Controls.Add(delRowsButton);
            settingsPanel.Controls.Add(rowsIdBox);
            settingsPanel.Controls.Add(hideSetPanel);
            settingsPanel.Controls.Add(changeButtonEnd);
            settingsPanel.Controls.Add(valueInput);
            settingsPanel.Location = new Point(380, 24);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(425, 294);
            settingsPanel.TabIndex = 21;
            settingsPanel.Visible = false;
            // 
            // delRowsButton
            // 
            delRowsButton.BackColor = Color.FromArgb(26, 155, 131);
            delRowsButton.Cursor = Cursors.Hand;
            delRowsButton.FlatStyle = FlatStyle.Flat;
            delRowsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delRowsButton.ForeColor = Color.White;
            delRowsButton.Location = new Point(35, 126);
            delRowsButton.Name = "delRowsButton";
            delRowsButton.Size = new Size(133, 44);
            delRowsButton.TabIndex = 24;
            delRowsButton.Text = "Удалить";
            delRowsButton.UseVisualStyleBackColor = false;
            delRowsButton.Visible = false;
            delRowsButton.Click += delRowsButton_Click;
            // 
            // rowsIdBox
            // 
            rowsIdBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rowsIdBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rowsIdBox.FormattingEnabled = true;
            rowsIdBox.Location = new Point(35, 48);
            rowsIdBox.Name = "rowsIdBox";
            rowsIdBox.Size = new Size(184, 36);
            rowsIdBox.TabIndex = 23;
            rowsIdBox.Visible = false;
            // 
            // hideSetPanel
            // 
            hideSetPanel.AutoSize = true;
            hideSetPanel.Cursor = Cursors.Hand;
            hideSetPanel.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            hideSetPanel.ForeColor = Color.FromArgb(192, 0, 0);
            hideSetPanel.Location = new Point(392, 4);
            hideSetPanel.Name = "hideSetPanel";
            hideSetPanel.Size = new Size(30, 31);
            hideSetPanel.TabIndex = 22;
            hideSetPanel.Text = "X";
            hideSetPanel.Click += hideSetPanel_Click;
            // 
            // changeButtonEnd
            // 
            changeButtonEnd.BackColor = Color.FromArgb(26, 155, 131);
            changeButtonEnd.Cursor = Cursors.Hand;
            changeButtonEnd.FlatStyle = FlatStyle.Flat;
            changeButtonEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changeButtonEnd.ForeColor = Color.White;
            changeButtonEnd.Location = new Point(35, 84);
            changeButtonEnd.Name = "changeButtonEnd";
            changeButtonEnd.Size = new Size(133, 44);
            changeButtonEnd.TabIndex = 21;
            changeButtonEnd.Text = "Изменить";
            changeButtonEnd.UseVisualStyleBackColor = false;
            changeButtonEnd.Visible = false;
            changeButtonEnd.Click += changeButtonEnd_Click;
            // 
            // valueInput
            // 
            valueInput.BorderStyle = BorderStyle.FixedSingle;
            valueInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            valueInput.Location = new Point(35, 28);
            valueInput.Name = "valueInput";
            valueInput.Size = new Size(264, 38);
            valueInput.TabIndex = 20;
            valueInput.Visible = false;
            // 
            // changeValueButton
            // 
            changeValueButton.BackColor = Color.FromArgb(26, 155, 131);
            changeValueButton.Cursor = Cursors.Hand;
            changeValueButton.FlatStyle = FlatStyle.Flat;
            changeValueButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changeValueButton.ForeColor = Color.White;
            changeValueButton.Location = new Point(27, 150);
            changeValueButton.Name = "changeValueButton";
            changeValueButton.Size = new Size(133, 81);
            changeValueButton.TabIndex = 19;
            changeValueButton.Text = "Изменить значение";
            changeValueButton.UseVisualStyleBackColor = false;
            changeValueButton.Click += changeValueButton_Click;
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
            dbTable.Location = new Point(27, 42);
            dbTable.Name = "dbTable";
            dbTable.ReadOnly = true;
            dbTable.RowHeadersWidth = 51;
            dbTable.Size = new Size(778, 329);
            dbTable.TabIndex = 0;
            dbTable.CellClick += dbTable_CellClick;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1263, 790);
            Controls.Add(dbPanel);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Controls.Add(panelUpAdmin);
            Name = "ManagerForm";
            Text = "AdminForm";
            panelUpAdmin.ResumeLayout(false);
            panelUpAdmin.PerformLayout();
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            dbPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dbTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label closeButton;
        private Label adminLabel;
        private Label nameManager;
        private Panel panelUpAdmin;
        private Panel mainPanel;
        private Button detailsButtons;
        private Button orderButton;
        private Button categoriesButton;
        private Button productsButton;
        private Panel panel1;
        private Button addButton;
        private Button zaprosButton;
        private Button deleteButton;
        private Button exitButton;
        private Panel dbPanel;
        private Panel infoPanel;
        private Label valueLabel;
        private Label label6;
        private Label colIndexLabel;
        private Label rowIndexLabel;
        private Label tableNameLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dbTable;
        private Button changeValueButton;
        private Panel settingsPanel;
        private Button changeButtonEnd;
        private TextBox valueInput;
        private Label hideSetPanel;
        private Label rebootTable;
        private Button delRowsButton;
        private ComboBox rowsIdBox;
    }
}