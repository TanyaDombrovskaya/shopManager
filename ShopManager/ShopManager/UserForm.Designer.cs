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
            panelUpUser = new Panel();
            panelUpUser.SuspendLayout();
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
            closeButton.TabIndex = 7;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(35, 14);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(145, 28);
            userLabel.TabIndex = 10;
            userLabel.Text = "Пользователь";
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameUser.ForeColor = Color.White;
            nameUser.Location = new Point(186, 14);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(104, 28);
            nameUser.TabIndex = 11;
            nameUser.Text = "nameUser";
            // 
            // panelUpUser
            // 
            panelUpUser.BackColor = Color.Teal;
            panelUpUser.Controls.Add(userLabel);
            panelUpUser.Controls.Add(closeButton);
            panelUpUser.Controls.Add(nameUser);
            panelUpUser.Dock = DockStyle.Top;
            panelUpUser.Location = new Point(0, 0);
            panelUpUser.Name = "panelUpUser";
            panelUpUser.Size = new Size(1263, 59);
            panelUpUser.TabIndex = 12;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 790);
            Controls.Add(panelUpUser);
            Name = "UserForm";
            Text = "UserForm";
            panelUpUser.ResumeLayout(false);
            panelUpUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label closeButton;
        private Label userLabel;
        private Label nameUser;
        private Panel panelUpUser;
    }
}