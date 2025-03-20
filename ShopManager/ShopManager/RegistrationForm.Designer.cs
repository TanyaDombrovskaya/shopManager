namespace ShopManager
{
    partial class RegistrationForm
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
            passwordLabelReg = new Label();
            loginLabelReg = new Label();
            passwordRegInput = new TextBox();
            loginIRegInput = new TextBox();
            kodLabelReg = new Label();
            codeInput = new TextBox();
            RegButton = new Button();
            autoLabel = new Label();
            nameLabel = new Label();
            nameInput = new TextBox();
            surnameLabel = new Label();
            surnameInput = new TextBox();
            emailLabel = new Label();
            emailInput = new TextBox();
            iLabel = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.Location = new Point(504, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(28, 31);
            closeButton.TabIndex = 7;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // passwordLabelReg
            // 
            passwordLabelReg.AutoSize = true;
            passwordLabelReg.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabelReg.ForeColor = Color.FromArgb(15, 0, 0);
            passwordLabelReg.Location = new Point(59, 146);
            passwordLabelReg.Name = "passwordLabelReg";
            passwordLabelReg.Size = new Size(96, 31);
            passwordLabelReg.TabIndex = 11;
            passwordLabelReg.Text = "Пароль";
            // 
            // loginLabelReg
            // 
            loginLabelReg.AutoSize = true;
            loginLabelReg.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabelReg.ForeColor = Color.FromArgb(15, 0, 0);
            loginLabelReg.Location = new Point(59, 78);
            loginLabelReg.Name = "loginLabelReg";
            loginLabelReg.Size = new Size(81, 31);
            loginLabelReg.TabIndex = 10;
            loginLabelReg.Text = "Логин";
            // 
            // passwordRegInput
            // 
            passwordRegInput.BorderStyle = BorderStyle.FixedSingle;
            passwordRegInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordRegInput.Location = new Point(192, 144);
            passwordRegInput.Name = "passwordRegInput";
            passwordRegInput.Size = new Size(294, 38);
            passwordRegInput.TabIndex = 9;
            // 
            // loginIRegInput
            // 
            loginIRegInput.BorderStyle = BorderStyle.FixedSingle;
            loginIRegInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginIRegInput.Location = new Point(192, 76);
            loginIRegInput.Name = "loginIRegInput";
            loginIRegInput.Size = new Size(294, 38);
            loginIRegInput.TabIndex = 8;
            // 
            // kodLabelReg
            // 
            kodLabelReg.AutoSize = true;
            kodLabelReg.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            kodLabelReg.ForeColor = Color.FromArgb(15, 0, 0);
            kodLabelReg.Location = new Point(59, 213);
            kodLabelReg.Name = "kodLabelReg";
            kodLabelReg.Size = new Size(55, 31);
            kodLabelReg.TabIndex = 12;
            kodLabelReg.Text = "Код";
            // 
            // codeInput
            // 
            codeInput.BorderStyle = BorderStyle.FixedSingle;
            codeInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            codeInput.Location = new Point(192, 211);
            codeInput.Name = "codeInput";
            codeInput.Size = new Size(294, 38);
            codeInput.TabIndex = 13;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(15, 0, 0);
            RegButton.Cursor = Cursors.Hand;
            RegButton.FlatStyle = FlatStyle.Flat;
            RegButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegButton.ForeColor = Color.White;
            RegButton.Location = new Point(128, 492);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(291, 56);
            RegButton.TabIndex = 14;
            RegButton.TabStop = false;
            RegButton.Text = "Регистрация";
            RegButton.UseVisualStyleBackColor = false;
            RegButton.Click += RegButton_Click;
            // 
            // autoLabel
            // 
            autoLabel.AutoSize = true;
            autoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            autoLabel.Location = new Point(12, 9);
            autoLabel.Name = "autoLabel";
            autoLabel.Size = new Size(129, 28);
            autoLabel.TabIndex = 15;
            autoLabel.Text = "Регистрация";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.ForeColor = Color.FromArgb(15, 0, 0);
            nameLabel.Location = new Point(59, 279);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(61, 31);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Имя";
            // 
            // nameInput
            // 
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameInput.Location = new Point(192, 277);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(294, 38);
            nameInput.TabIndex = 17;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.ForeColor = Color.FromArgb(15, 0, 0);
            surnameLabel.Location = new Point(56, 347);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(114, 31);
            surnameLabel.TabIndex = 18;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameInput
            // 
            surnameInput.BorderStyle = BorderStyle.FixedSingle;
            surnameInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameInput.Location = new Point(192, 345);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(294, 38);
            surnameInput.TabIndex = 19;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.ForeColor = Color.FromArgb(15, 0, 0);
            emailLabel.Location = new Point(59, 410);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailInput.Location = new Point(192, 408);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(294, 38);
            emailInput.TabIndex = 21;
            // 
            // iLabel
            // 
            iLabel.AutoSize = true;
            iLabel.Cursor = Cursors.Hand;
            iLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            iLabel.ForeColor = Color.Blue;
            iLabel.Location = new Point(113, 211);
            iLabel.Name = "iLabel";
            iLabel.Size = new Size(16, 25);
            iLabel.TabIndex = 22;
            iLabel.Text = "i";
            iLabel.Click += iLabel_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(544, 580);
            Controls.Add(iLabel);
            Controls.Add(emailInput);
            Controls.Add(emailLabel);
            Controls.Add(surnameInput);
            Controls.Add(surnameLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Controls.Add(autoLabel);
            Controls.Add(RegButton);
            Controls.Add(codeInput);
            Controls.Add(kodLabelReg);
            Controls.Add(passwordLabelReg);
            Controls.Add(loginLabelReg);
            Controls.Add(passwordRegInput);
            Controls.Add(loginIRegInput);
            Controls.Add(closeButton);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeButton;
        private Label passwordLabelReg;
        private Label loginLabelReg;
        private TextBox passwordRegInput;
        private TextBox loginIRegInput;
        private Label kodLabelReg;
        private TextBox codeInput;
        private Button RegButton;
        private Label autoLabel;
        private Label nameLabel;
        private TextBox nameInput;
        private Label surnameLabel;
        private TextBox surnameInput;
        private Label emailLabel;
        private TextBox emailInput;
        private Label iLabel;
    }
}