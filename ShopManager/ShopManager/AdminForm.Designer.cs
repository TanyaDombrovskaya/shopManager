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
            closeButton = new Label();
            adminLabel = new Label();
            nameAdmin = new Label();
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
            closeButton.TabIndex = 8;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            adminLabel.Location = new Point(12, 9);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(162, 28);
            adminLabel.TabIndex = 9;
            adminLabel.Text = "Администратор";
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameAdmin.Location = new Point(180, 9);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(123, 28);
            nameAdmin.TabIndex = 10;
            nameAdmin.Text = "nameAdmin";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 743);
            Controls.Add(nameAdmin);
            Controls.Add(adminLabel);
            Controls.Add(closeButton);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeButton;
        private Label adminLabel;
        private Label nameAdmin;
    }
}