namespace ShopManager
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginInput = new TextBox();
            passwordInput = new TextBox();
            loginButton = new Button();
            loginLabel = new Label();
            passwordLabel = new Label();
            registrationLink = new LinkLabel();
            closeButton = new Label();
            autoLabel = new Label();
            SuspendLayout();
            // 
            // loginInput
            // 
            loginInput.BorderStyle = BorderStyle.FixedSingle;
            loginInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginInput.Location = new Point(229, 84);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(294, 38);
            loginInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordInput.Location = new Point(229, 167);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(294, 38);
            passwordInput.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(15, 0, 0);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(180, 257);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(291, 56);
            loginButton.TabIndex = 2;
            loginButton.TabStop = false;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            loginButton.MouseDown += loginButton_MouseDown;
            loginButton.MouseUp += loginButton_MouseUp;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.ForeColor = Color.FromArgb(15, 0, 0);
            loginLabel.Location = new Point(117, 89);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(81, 31);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.ForeColor = Color.FromArgb(15, 0, 0);
            passwordLabel.Location = new Point(117, 172);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(96, 31);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Пароль";
            // 
            // registrationLink
            // 
            registrationLink.ActiveLinkColor = SystemColors.ActiveCaptionText;
            registrationLink.AutoSize = true;
            registrationLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registrationLink.Location = new Point(258, 319);
            registrationLink.Name = "registrationLink";
            registrationLink.Size = new Size(129, 28);
            registrationLink.TabIndex = 5;
            registrationLink.TabStop = true;
            registrationLink.Text = "Регистрация";
            registrationLink.LinkClicked += registrationLink_LinkClicked;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.Location = new Point(597, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(28, 31);
            closeButton.TabIndex = 6;
            closeButton.Text = "X";
            closeButton.Click += label1_Click;
            // 
            // autoLabel
            // 
            autoLabel.AutoSize = true;
            autoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            autoLabel.Location = new Point(12, 9);
            autoLabel.Name = "autoLabel";
            autoLabel.Size = new Size(135, 28);
            autoLabel.TabIndex = 7;
            autoLabel.Text = "Авторизация";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(637, 399);
            Controls.Add(autoLabel);
            Controls.Add(closeButton);
            Controls.Add(registrationLink);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(loginInput);
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginInput;
        private TextBox passwordInput;
        private Button loginButton;
        private Label loginLabel;
        private Label passwordLabel;
        private LinkLabel registrationLink;
        private Label closeButton;
        private Label autoLabel;
    }
}
