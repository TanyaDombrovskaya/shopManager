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
            loginRegInput = new TextBox();
            RegButton = new Button();
            autoLabel = new Label();
            nameLabel = new Label();
            nameInput = new TextBox();
            surnameLabel = new Label();
            surnameInput = new TextBox();
            emailLabel = new Label();
            emailInput = new TextBox();
            panelUpReg = new Panel();
            label1 = new Label();
            panelUpReg.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.FromArgb(192, 0, 0);
            closeButton.Location = new Point(502, 13);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 31);
            closeButton.TabIndex = 7;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // passwordLabelReg
            // 
            passwordLabelReg.AutoSize = true;
            passwordLabelReg.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabelReg.ForeColor = Color.FromArgb(15, 0, 0);
            passwordLabelReg.Location = new Point(59, 157);
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
            loginLabelReg.Location = new Point(59, 89);
            loginLabelReg.Name = "loginLabelReg";
            loginLabelReg.Size = new Size(81, 31);
            loginLabelReg.TabIndex = 10;
            loginLabelReg.Text = "Логин";
            // 
            // passwordRegInput
            // 
            passwordRegInput.BorderStyle = BorderStyle.FixedSingle;
            passwordRegInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordRegInput.Location = new Point(192, 155);
            passwordRegInput.Name = "passwordRegInput";
            passwordRegInput.Size = new Size(294, 38);
            passwordRegInput.TabIndex = 9;
            passwordRegInput.UseSystemPasswordChar = true;
            // 
            // loginRegInput
            // 
            loginRegInput.BorderStyle = BorderStyle.FixedSingle;
            loginRegInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginRegInput.Location = new Point(192, 87);
            loginRegInput.Name = "loginRegInput";
            loginRegInput.Size = new Size(294, 38);
            loginRegInput.TabIndex = 8;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(15, 0, 0);
            RegButton.Cursor = Cursors.Hand;
            RegButton.FlatStyle = FlatStyle.Flat;
            RegButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegButton.ForeColor = Color.White;
            RegButton.Location = new Point(126, 441);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(291, 56);
            RegButton.TabIndex = 14;
            RegButton.TabStop = false;
            RegButton.Text = "Регистрация";
            RegButton.UseVisualStyleBackColor = false;
            RegButton.Click += RegButton_Click;
            RegButton.MouseDown += RegButton_MouseDown;
            RegButton.MouseUp += RegButton_MouseUp;
            // 
            // autoLabel
            // 
            autoLabel.AutoSize = true;
            autoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            autoLabel.ForeColor = Color.White;
            autoLabel.Location = new Point(35, 14);
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
            nameLabel.Location = new Point(59, 225);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(61, 31);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Имя";
            // 
            // nameInput
            // 
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameInput.Location = new Point(192, 223);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(294, 38);
            nameInput.TabIndex = 17;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.ForeColor = Color.FromArgb(15, 0, 0);
            surnameLabel.Location = new Point(59, 295);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(114, 31);
            surnameLabel.TabIndex = 18;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameInput
            // 
            surnameInput.BorderStyle = BorderStyle.FixedSingle;
            surnameInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameInput.Location = new Point(192, 293);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(294, 38);
            surnameInput.TabIndex = 19;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.ForeColor = Color.FromArgb(15, 0, 0);
            emailLabel.Location = new Point(59, 368);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(70, 31);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.BorderStyle = BorderStyle.FixedSingle;
            emailInput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailInput.Location = new Point(192, 366);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(294, 38);
            emailInput.TabIndex = 21;
            // 
            // panelUpReg
            // 
            panelUpReg.BackColor = Color.Teal;
            panelUpReg.Controls.Add(label1);
            panelUpReg.Controls.Add(autoLabel);
            panelUpReg.Controls.Add(closeButton);
            panelUpReg.Dock = DockStyle.Top;
            panelUpReg.Location = new Point(0, 0);
            panelUpReg.Name = "panelUpReg";
            panelUpReg.Size = new Size(544, 59);
            panelUpReg.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(1221, 12);
            label1.Name = "label1";
            label1.Size = new Size(30, 31);
            label1.TabIndex = 8;
            label1.Text = "X";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(544, 537);
            Controls.Add(panelUpReg);
            Controls.Add(emailInput);
            Controls.Add(emailLabel);
            Controls.Add(surnameInput);
            Controls.Add(surnameLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Controls.Add(RegButton);
            Controls.Add(passwordLabelReg);
            Controls.Add(loginLabelReg);
            Controls.Add(passwordRegInput);
            Controls.Add(loginRegInput);
            Name = "RegistrationForm";
            Text = "Registration";
            panelUpReg.ResumeLayout(false);
            panelUpReg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeButton;
        private Label passwordLabelReg;
        private Label loginLabelReg;
        private TextBox passwordRegInput;
        private TextBox loginRegInput;
        private Button RegButton;
        private Label autoLabel;
        private Label nameLabel;
        private TextBox nameInput;
        private Label surnameLabel;
        private TextBox surnameInput;
        private Label emailLabel;
        private TextBox emailInput;
        private Panel panelUpReg;
        private Label label1;
    }
}