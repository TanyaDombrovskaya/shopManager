namespace ShopManager
{
    partial class UserForm
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
            userLabel = new Label();
            nameUser = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.Location = new Point(1143, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(28, 31);
            closeButton.TabIndex = 7;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userLabel.Location = new Point(12, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(145, 28);
            userLabel.TabIndex = 10;
            userLabel.Text = "Пользователь";
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameUser.Location = new Point(163, 9);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(104, 28);
            nameUser.TabIndex = 11;
            nameUser.Text = "nameUser";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 743);
            Controls.Add(nameUser);
            Controls.Add(userLabel);
            Controls.Add(closeButton);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeButton;
        private Label userLabel;
        private Label nameUser;
    }
}