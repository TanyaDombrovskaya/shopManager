namespace ShopManager.Forms
{
    partial class AdminForm
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
            lblWelcome = new Label();
            dataGridViewUsers = new DataGridView();
            btnBanUser = new Button();
            btnUnbanUser = new Button();
            btnChangeRole = new Button();
            btnDeleteUser = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
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
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.BackgroundColor = Color.FromArgb(250, 250, 252);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.Location = new Point(40, 123);
            dataGridViewUsers.Margin = new Padding(4, 5, 4, 5);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(987, 538);
            dataGridViewUsers.TabIndex = 1;
            // 
            // btnBanUser
            // 
            btnBanUser.BackColor = Color.FromArgb(239, 83, 80);
            btnBanUser.FlatAppearance.BorderColor = Color.FromArgb(215, 70, 70);
            btnBanUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 60, 60);
            btnBanUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 70, 70);
            btnBanUser.FlatStyle = FlatStyle.Flat;
            btnBanUser.ForeColor = Color.White;
            btnBanUser.Location = new Point(40, 692);
            btnBanUser.Margin = new Padding(4, 5, 4, 5);
            btnBanUser.Name = "btnBanUser";
            btnBanUser.Size = new Size(173, 62);
            btnBanUser.TabIndex = 2;
            btnBanUser.Text = "Заблокировать";
            btnBanUser.UseVisualStyleBackColor = false;
            btnBanUser.Click += btnBanUser_Click;
            // 
            // btnUnbanUser
            // 
            btnUnbanUser.BackColor = Color.FromArgb(102, 187, 106);
            btnUnbanUser.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnUnbanUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnUnbanUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnUnbanUser.FlatStyle = FlatStyle.Flat;
            btnUnbanUser.ForeColor = Color.White;
            btnUnbanUser.Location = new Point(227, 692);
            btnUnbanUser.Margin = new Padding(4, 5, 4, 5);
            btnUnbanUser.Name = "btnUnbanUser";
            btnUnbanUser.Size = new Size(173, 62);
            btnUnbanUser.TabIndex = 3;
            btnUnbanUser.Text = "Разблокировать";
            btnUnbanUser.UseVisualStyleBackColor = false;
            btnUnbanUser.Click += btnUnbanUser_Click;
            // 
            // btnChangeRole
            // 
            btnChangeRole.BackColor = Color.FromArgb(255, 202, 40);
            btnChangeRole.FlatAppearance.BorderColor = Color.FromArgb(220, 175, 35);
            btnChangeRole.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 155, 30);
            btnChangeRole.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 175, 35);
            btnChangeRole.FlatStyle = FlatStyle.Flat;
            btnChangeRole.ForeColor = Color.Black;
            btnChangeRole.Location = new Point(413, 692);
            btnChangeRole.Margin = new Padding(4, 5, 4, 5);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(173, 62);
            btnChangeRole.TabIndex = 4;
            btnChangeRole.Text = "Изменить роль";
            btnChangeRole.UseVisualStyleBackColor = false;
            btnChangeRole.Click += btnChangeRole_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(239, 83, 80);
            btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(215, 70, 70);
            btnDeleteUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 60, 60);
            btnDeleteUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 70, 70);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(600, 692);
            btnDeleteUser.Margin = new Padding(4, 5, 4, 5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(173, 62);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Удалить";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(117, 117, 117);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(787, 692);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 62);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(1071, 785);
            Controls.Add(btnLogout);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnChangeRole);
            Controls.Add(btnUnbanUser);
            Controls.Add(btnBanUser);
            Controls.Add(dataGridViewUsers);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Панель администратора";
            Paint += AdminForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnBanUser;
        private System.Windows.Forms.Button btnUnbanUser;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnLogout;

        private void AdminForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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