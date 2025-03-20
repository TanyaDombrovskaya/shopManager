using System;
using System.Windows.Forms;

namespace ShopManager
{
    public class Base : Form
    {
        public Base() {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.LightCyan;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCAPTION = 0x2;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
        }
    }
}
