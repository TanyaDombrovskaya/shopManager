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
            panelUpAdmin = new Panel();
            panelUpAdmin.SuspendLayout();
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
            closeButton.TabIndex = 8;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            adminLabel.ForeColor = Color.White;
            adminLabel.Location = new Point(35, 14);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(162, 28);
            adminLabel.TabIndex = 9;
            adminLabel.Text = "Администратор";
            adminLabel.Click += adminLabel_Click;
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameAdmin.ForeColor = Color.White;
            nameAdmin.Location = new Point(203, 14);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(123, 28);
            nameAdmin.TabIndex = 10;
            nameAdmin.Text = "nameAdmin";
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
            panelUpAdmin.Size = new Size(1263, 59);
            panelUpAdmin.TabIndex = 11;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1263, 790);
            Controls.Add(panelUpAdmin);
            Name = "AdminForm";
            Text = "AdminForm";
            panelUpAdmin.ResumeLayout(false);
            panelUpAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label closeButton;
        private Label adminLabel;
        private Label nameAdmin;
        private Panel panelUpAdmin;
    }
}