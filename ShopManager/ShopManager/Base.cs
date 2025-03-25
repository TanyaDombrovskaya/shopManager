using System;
using System.Windows.Forms;

namespace ShopManager
{
    public class Base : Form
    {
        private Point lastMousePosition;

        public Base()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.LightCyan;
        }

        protected void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMousePosition = e.Location;
            }
        }

        protected void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastMousePosition.X;
                this.Top += e.Y - lastMousePosition.Y;
            }
        }
    }
}
