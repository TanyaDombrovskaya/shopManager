using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ShopManager
{ 
    public partial class LoginForm : Base
    {
        public DatabaseManager db = new DatabaseManager();

        public LoginForm()
        {
            InitializeComponent();

            panelUpLogin.MouseDown += PanelHeader_MouseDown;
            panelUpLogin.MouseMove += PanelHeader_MouseMove;

            DatabaseManager dbd = new DatabaseManager();
            int id = GlobalID.ReadID();
            string dostup = dbd.UserDostup(id);

            DatabaseManager db = new DatabaseManager();
            string user = db.GetUserName(id);

            if (!string.IsNullOrEmpty(dostup))
            {
                Form nextForm = null;

                if (dostup.Equals("manager", StringComparison.OrdinalIgnoreCase))
                {
                    nextForm = new ManagerForm();

                    ((ManagerForm)nextForm).NameManager = user;
                }
                else if (dostup.Equals("admin", StringComparison.OrdinalIgnoreCase))
                { 
                    nextForm = new AdminForm();

                    ((AdminForm)nextForm).NameAdmin = user;
                }
                else if (dostup.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    nextForm = new UserForm();

                    ((UserForm)nextForm).NameUser = user;
                }
                else
                {
                    MessageBox.Show("����������� ������� �������.");
                    return;
                }

                this.Hide();
                Application.Run(nextForm);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;

            DatabaseManager dbManager1 = new DatabaseManager();
            int id = dbManager1.GetID(login);
            GlobalID.ID = id;
            GlobalID.WriteID();

            DatabaseManager dbManager2 = new DatabaseManager();
            string role = dbManager2.UserDostup(id);

            if (role != null)
            {
                DatabaseManager dbManager3 = new DatabaseManager();
                bool result = dbManager3.UserConnect(login);

                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();

                    adminform.NameAdmin = login;
                }
                if (role.Equals("manager", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    ManagerForm managerform = new ManagerForm();
                    managerform.Show();

                    managerform.NameManager = login;
                }
                else if (role.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    this.Hide();
                    UserForm userform = new UserForm();
                    userform.Show();

                    userform.NameUser = login;
                }
            }
            else
            {
                MessageBox.Show("������������ �� ������.");
            }
        }

        private void loginButton_MouseDown(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(107, 61, 235);
            loginButton.ForeColor = Color.White;
        }

        private void loginButton_MouseUp(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(26, 155, 131);
            loginButton.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
