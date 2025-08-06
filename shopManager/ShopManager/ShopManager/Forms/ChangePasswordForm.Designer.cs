namespace ShopManager.Forms
{
    partial class ChangePasswordForm
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(0, 102, 204);
            lblEmail.Location = new Point(20, 20);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(111, 28);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Ваш email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 252);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(50, 50, 50);
            txtEmail.Location = new Point(20, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 30);
            txtEmail.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(0, 102, 204);
            lblNewPassword.Location = new Point(20, 84);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(156, 28);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "Новый пароль";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(250, 250, 252);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.ForeColor = Color.FromArgb(50, 50, 50);
            txtNewPassword.Location = new Point(20, 115);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(300, 30);
            txtNewPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(0, 102, 204);
            lblConfirmPassword.Location = new Point(20, 148);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(216, 28);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Подтвердите пароль";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(250, 250, 252);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(50, 50, 50);
            txtConfirmPassword.Location = new Point(20, 179);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(300, 30);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(102, 187, 106);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(85, 160, 90);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 140, 75);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 160, 90);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(133, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(117, 117, 117);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(240, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(340, 280);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Смена пароля";
            Paint += ChangePasswordForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void ChangePasswordForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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