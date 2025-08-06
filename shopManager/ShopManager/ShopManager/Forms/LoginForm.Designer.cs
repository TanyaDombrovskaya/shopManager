namespace ShopManager.Forms
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkRegister = new LinkLabel();
            linkChangePass = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(180, 50);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(193, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Авторизация";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(70, 120);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(157, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Имя пользователя";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(250, 250, 252);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(70, 150);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 30);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(70, 200);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(250, 250, 252);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(70, 230);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(400, 30);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 102, 204);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 84, 180);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 70, 150);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 84, 180);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(180, 300);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.FromArgb(0, 102, 204);
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 9F);
            linkRegister.LinkColor = Color.FromArgb(0, 102, 204);
            linkRegister.Location = new Point(203, 370);
            linkRegister.Margin = new Padding(4, 0, 4, 0);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(151, 20);
            linkRegister.TabIndex = 6;
            linkRegister.TabStop = true;
            linkRegister.Text = "Зарегистрироваться";
            linkRegister.VisitedLinkColor = Color.FromArgb(0, 102, 204);
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // linkChangePass
            // 
            linkChangePass.ActiveLinkColor = Color.FromArgb(0, 102, 204);
            linkChangePass.AutoSize = true;
            linkChangePass.BackColor = Color.FromArgb(250, 250, 252);
            linkChangePass.Font = new Font("Segoe UI", 9F);
            linkChangePass.LinkColor = Color.FromArgb(0, 102, 204);
            linkChangePass.Location = new Point(215, 400);
            linkChangePass.Margin = new Padding(4, 0, 4, 0);
            linkChangePass.Name = "linkChangePass";
            linkChangePass.Size = new Size(124, 20);
            linkChangePass.TabIndex = 7;
            linkChangePass.TabStop = true;
            linkChangePass.Text = "Сменить пароль";
            linkChangePass.VisitedLinkColor = Color.FromArgb(0, 102, 204);
            linkChangePass.LinkClicked += linkChangePass_LinkClicked_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(540, 500);
            Controls.Add(linkChangePass);
            Controls.Add(linkRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            Paint += LoginForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private LinkLabel linkChangePass;

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 250, 250, 252),
                Color.FromArgb(255, 240, 240, 248),
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}