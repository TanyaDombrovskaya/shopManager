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

                if (dostup.Equals("admin", StringComparison.OrdinalIgnoreCase))
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
                    MessageBox.Show("Неизвестный уровень доступа.");
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
                MessageBox.Show("Пользователь не найден.");
            }
        }

        private void loginButton_MouseDown(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.Black;
        }

        private void loginButton_MouseUp(object sender, MouseEventArgs e)
        {
            loginButton.BackColor = Color.Black;
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
