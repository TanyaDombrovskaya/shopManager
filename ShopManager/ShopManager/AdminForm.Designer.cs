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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelUpAdmin = new Panel();
            adminLabel = new Label();
            closeButton = new Label();
            nameAdmin = new Label();
            mainPanel = new Panel();
            exitButton = new Button();
            pravaButton = new Button();
            usersButton = new Button();
            dbPanel = new Panel();
            banPanel = new Panel();
            banButton = new Button();
            label8 = new Label();
            userBox = new ComboBox();
            pravaPanel = new Panel();
            label7 = new Label();
            label4 = new Label();
            changePrava = new Button();
            pravaBox = new ComboBox();
            usersBox = new ComboBox();
            IPA = new Panel();
            VLA = new Label();
            label5 = new Label();
            CILA = new Label();
            RILA = new Label();
            tableNameLabelAdmin = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
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
            dbPanel.SuspendLayout();
            banPanel.SuspendLayout();
            pravaPanel.SuspendLayout();
            IPA.SuspendLayout();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbTable).BeginInit();
            SuspendLayout();
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
            panelUpAdmin.Size = new Size(1245, 59);
            panelUpAdmin.TabIndex = 12;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            adminLabel.ForeColor = Color.White;
            adminLabel.Location = new Point(35, 14);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(80, 28);
            adminLabel.TabIndex = 9;
            adminLabel.Text = "Админ";
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.FromArgb(192, 0, 0);
            closeButton.Location = new Point(1203, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 31);
            closeButton.TabIndex = 8;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameAdmin.ForeColor = Color.White;
            nameAdmin.Location = new Point(121, 14);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(126, 28);
            nameAdmin.TabIndex = 10;
            nameAdmin.Text = "nameAdmin\r\n";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(99, 164, 191);
            mainPanel.Controls.Add(exitButton);
            mainPanel.Controls.Add(pravaButton);
            mainPanel.Controls.Add(usersButton);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 59);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(221, 684);
            mainPanel.TabIndex = 13;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(26, 155, 131);
            exitButton.Cursor = Cursors.Hand;
            exitButton.Dock = DockStyle.Top;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(0, 136);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(221, 68);
            exitButton.TabIndex = 7;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // pravaButton
            // 
            pravaButton.BackColor = Color.FromArgb(26, 155, 131);
            pravaButton.Cursor = Cursors.Hand;
            pravaButton.Dock = DockStyle.Top;
            pravaButton.FlatStyle = FlatStyle.Flat;
            pravaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pravaButton.ForeColor = Color.White;
            pravaButton.Location = new Point(0, 68);
            pravaButton.Name = "pravaButton";
            pravaButton.Size = new Size(221, 68);
            pravaButton.TabIndex = 6;
            pravaButton.Text = "Права";
            pravaButton.UseVisualStyleBackColor = false;
            pravaButton.Click += pravaButton_Click;
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
            // dbPanel
            // 
            dbPanel.Controls.Add(banPanel);
            dbPanel.Controls.Add(pravaPanel);
            dbPanel.Controls.Add(IPA);
            dbPanel.Controls.Add(infoPanel);
            dbPanel.Controls.Add(dbTable);
            dbPanel.Dock = DockStyle.Right;
            dbPanel.Location = new Point(219, 59);
            dbPanel.Name = "dbPanel";
            dbPanel.Size = new Size(1026, 684);
            dbPanel.TabIndex = 14;
            dbPanel.Visible = false;
            // 
            // banPanel
            // 
            banPanel.BackColor = Color.Teal;
            banPanel.Controls.Add(banButton);
            banPanel.Controls.Add(label8);
            banPanel.Controls.Add(userBox);
            banPanel.Location = new Point(550, 153);
            banPanel.Name = "banPanel";
            banPanel.Size = new Size(429, 237);
            banPanel.TabIndex = 12;
            banPanel.Visible = false;
            // 
            // banButton
            // 
            banButton.BackColor = Color.White;
            banButton.FlatStyle = FlatStyle.Flat;
            banButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            banButton.ForeColor = Color.Black;
            banButton.Location = new Point(108, 129);
            banButton.Name = "banButton";
            banButton.Size = new Size(215, 55);
            banButton.TabIndex = 13;
            banButton.Text = "Выдать бан";
            banButton.UseVisualStyleBackColor = false;
            banButton.Click += banButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(55, 55);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 12;
            label8.Text = "Пользователи";
            // 
            // userBox
            // 
            userBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userBox.FormattingEnabled = true;
            userBox.Location = new Point(214, 59);
            userBox.Name = "userBox";
            userBox.Size = new Size(151, 36);
            userBox.TabIndex = 11;
            // 
            // pravaPanel
            // 
            pravaPanel.BackColor = Color.Teal;
            pravaPanel.Controls.Add(label7);
            pravaPanel.Controls.Add(label4);
            pravaPanel.Controls.Add(changePrava);
            pravaPanel.Controls.Add(pravaBox);
            pravaPanel.Controls.Add(usersBox);
            pravaPanel.Location = new Point(78, 153);
            pravaPanel.Name = "pravaPanel";
            pravaPanel.Size = new Size(429, 251);
            pravaPanel.TabIndex = 3;
            pravaPanel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(108, 86);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 11;
            label7.Text = "Права";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 28);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 10;
            label4.Text = "Пользователи";
            // 
            // changePrava
            // 
            changePrava.BackColor = Color.White;
            changePrava.FlatStyle = FlatStyle.Flat;
            changePrava.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changePrava.ForeColor = Color.Black;
            changePrava.Location = new Point(108, 156);
            changePrava.Name = "changePrava";
            changePrava.Size = new Size(215, 55);
            changePrava.TabIndex = 2;
            changePrava.Text = "Изменить";
            changePrava.UseVisualStyleBackColor = false;
            changePrava.Click += changePrava_Click;
            // 
            // pravaBox
            // 
            pravaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pravaBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pravaBox.FormattingEnabled = true;
            pravaBox.Location = new Point(199, 90);
            pravaBox.Name = "pravaBox";
            pravaBox.Size = new Size(151, 36);
            pravaBox.TabIndex = 1;
            // 
            // usersBox
            // 
            usersBox.DropDownStyle = ComboBoxStyle.DropDownList;
            usersBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            usersBox.FormattingEnabled = true;
            usersBox.Location = new Point(199, 32);
            usersBox.Name = "usersBox";
            usersBox.Size = new Size(151, 36);
            usersBox.TabIndex = 0;
            // 
            // IPA
            // 
            IPA.Anchor = AnchorStyles.None;
            IPA.BackColor = Color.Teal;
            IPA.Controls.Add(VLA);
            IPA.Controls.Add(label5);
            IPA.Controls.Add(CILA);
            IPA.Controls.Add(RILA);
            IPA.Controls.Add(tableNameLabelAdmin);
            IPA.Controls.Add(label10);
            IPA.Controls.Add(label11);
            IPA.Controls.Add(label12);
            IPA.Location = new Point(0, 396);
            IPA.Name = "IPA";
            IPA.Size = new Size(1053, 314);
            IPA.TabIndex = 2;
            IPA.Visible = false;
            // 
            // VLA
            // 
            VLA.AutoSize = true;
            VLA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VLA.ForeColor = Color.White;
            VLA.Location = new Point(137, 108);
            VLA.Name = "VLA";
            VLA.Size = new Size(0, 28);
            VLA.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 108);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 17;
            label5.Text = "Значение: ";
            // 
            // CILA
            // 
            CILA.AutoSize = true;
            CILA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CILA.ForeColor = Color.White;
            CILA.Location = new Point(122, 52);
            CILA.Name = "CILA";
            CILA.Size = new Size(24, 28);
            CILA.TabIndex = 16;
            CILA.Text = "1";
            // 
            // RILA
            // 
            RILA.AutoSize = true;
            RILA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RILA.ForeColor = Color.White;
            RILA.Location = new Point(108, 80);
            RILA.Name = "RILA";
            RILA.Size = new Size(24, 28);
            RILA.TabIndex = 15;
            RILA.Text = "1";
            // 
            // tableNameLabelAdmin
            // 
            tableNameLabelAdmin.AutoSize = true;
            tableNameLabelAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableNameLabelAdmin.ForeColor = Color.White;
            tableNameLabelAdmin.Location = new Point(127, 24);
            tableNameLabelAdmin.Name = "tableNameLabelAdmin";
            tableNameLabelAdmin.Size = new Size(0, 28);
            tableNameLabelAdmin.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 80);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 13;
            label10.Text = "Строка: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.White;
            label11.Location = new Point(25, 52);
            label11.Name = "label11";
            label11.Size = new Size(104, 28);
            label11.TabIndex = 12;
            label11.Text = "Столбец: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.White;
            label12.Location = new Point(27, 24);
            label12.Name = "label12";
            label12.Size = new Size(105, 28);
            label12.TabIndex = 11;
            label12.Text = "Таблица: ";
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
            infoPanel.Location = new Point(413, 716);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dbTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dbTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dbTable.DefaultCellStyle = dataGridViewCellStyle4;
            dbTable.EnableHeadersVisualStyles = false;
            dbTable.Location = new Point(56, 30);
            dbTable.Name = "dbTable";
            dbTable.ReadOnly = true;
            dbTable.RowHeadersWidth = 51;
            dbTable.Size = new Size(778, 329);
            dbTable.TabIndex = 0;
            dbTable.Visible = false;
            dbTable.CellClick += dbTable_CellClick_1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 743);
            Controls.Add(dbPanel);
            Controls.Add(mainPanel);
            Controls.Add(panelUpAdmin);
            Name = "AdminForm";
            Text = "AdminForm";
            panelUpAdmin.ResumeLayout(false);
            panelUpAdmin.PerformLayout();
            mainPanel.ResumeLayout(false);
            dbPanel.ResumeLayout(false);
            banPanel.ResumeLayout(false);
            banPanel.PerformLayout();
            pravaPanel.ResumeLayout(false);
            pravaPanel.PerformLayout();
            IPA.ResumeLayout(false);
            IPA.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dbTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelUpAdmin;
        private Label adminLabel;
        private Label closeButton;
        private Label nameAdmin;
        private Panel mainPanel;
        private Button exitButton;
        private Button pravaButton;
        private Button usersButton;
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
        private Panel IPA;
        private Label VLA;
        private Label label5;
        private Label CILA;
        private Label RILA;
        private Label tableNameLabelAdmin;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel pravaPanel;
        private ComboBox usersBox;
        private ComboBox pravaBox;
        private Button changePrava;
        private Label label7;
        private Label label4;
        private Panel banPanel;
        private Button banButton;
        private Label label8;
        private ComboBox userBox;
    }
}