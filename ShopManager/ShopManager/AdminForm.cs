using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManager
{
    public partial class AdminForm : Base
    {
        private Point lastMousePosition;

        public AdminForm()
        {
            InitializeComponent();

            panelUpAdmin.MouseDown += PanelHeader_MouseDown;
            panelUpAdmin.MouseMove += PanelHeader_MouseMove;    
        }

        public string NameAdmin
        {
            get { return nameAdmin.Text; }
            set { nameAdmin.Text = value; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
