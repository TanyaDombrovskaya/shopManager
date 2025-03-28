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
        public List<Button> _buttonsMain = new List<Button>();
        public List<Button> _buttonsControl = new List<Button>();

        public AdminForm()
        {
            InitializeComponent();

            panelUpAdmin.MouseDown += PanelHeader_MouseDown;
            panelUpAdmin.MouseMove += PanelHeader_MouseMove;

            ChangeBorder();

            AddButtonsDB();
            PanelControl _panelControl1 = new(_buttonsMain);
            _panelControl1.AppendDictionary();

            AddButtonsControl();
            PanelControl _panelControl2 = new(_buttonsControl);
            _panelControl2.AppendDictionary();

            dbPanel.Parent = this;
            settingsPanel.Parent = this;
            dbTable.Parent = dbPanel;
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

        private void ChangeBorder()
        {
            usersButton.FlatAppearance.BorderSize = 0;
            productsButton.FlatAppearance.BorderSize = 0;
            categoriesButton.FlatAppearance.BorderSize = 0;
            orderButton.FlatAppearance.BorderSize = 0;
            detailsButtons.FlatAppearance.BorderSize = 0;
            settingsButton.FlatAppearance.BorderSize = 0;
            sortButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatAppearance.BorderSize = 0;
            zaprosButton.FlatAppearance.BorderSize = 0;
        }

        private void AddButtonsDB()
        {
            _buttonsMain.Add(usersButton);
            _buttonsMain.Add(productsButton);
            _buttonsMain.Add(categoriesButton);
            _buttonsMain.Add(orderButton);
            _buttonsMain.Add(detailsButtons);
            _buttonsMain.Add(settingsButton);
        }

        private void AddButtonsControl()
        {
            _buttonsControl.Add(sortButton);
            _buttonsControl.Add(filterButton);
            _buttonsControl.Add(zaprosButton);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalID.ReadID() <= 0)
                {
                    MessageBox.Show("Некорректный идентификатор пользователя.");
                    return;
                }

                DatabaseManager db = new DatabaseManager();

                if (db.ExitAccaunt(GlobalID.ReadID()))
                {
                    MessageBox.Show("Вы успешно вышли из аккаунта.");

                    GlobalID.ClearID();

                    LoginForm loginForm = new LoginForm();

                    this.Close();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка выхода из аккаунта.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            dbPanel.Visible = false;
        }

        private void detailsButtons_Click(object sender, EventArgs e)
        {
            string table = "orderDetails";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string table = "orders";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            string table = "categories";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            string table = "products";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            string table = "users";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;
        }
    }
}
