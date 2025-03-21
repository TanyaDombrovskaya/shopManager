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
    public partial class UserForm : Base
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public string NameUser
        {
            get { return nameUser.Text; }
            set { nameUser.Text = value; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
