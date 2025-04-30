using Microsoft.VisualBasic.ApplicationServices;
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
        public List<Button> _buttonsMain = new List<Button>();
        private int _rowIndex;
        private int _colIndex;
        private string _value;
        private List<string> prava = new List<string> { "user", "admin", "manager" };

        public AdminForm()
        {
            InitializeComponent();

            panelUpAdmin.MouseDown += PanelHeader_MouseDown;
            panelUpAdmin.MouseMove += PanelHeader_MouseMove;

            ChangeBorder();
            AddButtonsDB();

            PanelControl _panelControl1 = new(_buttonsMain);
            _panelControl1.AppendDictionary();
        }

        public string NameAdmin
        {
            get { return nameAdmin.Text; }
            set { nameAdmin.Text = value; }
        }

        private void ChangeBorder()
        {
            usersButton.FlatAppearance.BorderSize = 0;
            pravaButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.BorderSize = 0;
        }

        private void AddButtonsDB()
        {
            _buttonsMain.Add(usersButton);
            _buttonsMain.Add(pravaButton);
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        public void BaseValueSettings()
        {
            CILA.Text = "1";
            RILA.Text = "1";

            VLA.Text = Convert.ToString(dbTable.Rows[0].Cells[0].Value);
            VLA.Text = Convert.ToString(dbTable.Rows[0].Cells[0].Value);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            dbTable.Visible = true;
            IPA.Visible = true;
            pravaPanel.Visible = false;
            banPanel.Visible = false;

            string table = "users";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);
            dbTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dbTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dbTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dbPanel.Visible = true;

            tableNameLabelAdmin.Text = table;

            BaseValueSettings();
        }

        private void dbTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = 0;
            int colIndex = 0;
            string value = "";

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rowIndex = e.RowIndex;
                colIndex = e.ColumnIndex;
                value = Convert.ToString(dbTable.Rows[rowIndex].Cells[colIndex].Value);
            }

            _colIndex = colIndex + 1;
            _rowIndex = rowIndex + 1;
            _value = value;

            CILA.Text = Convert.ToString(_colIndex);
            RILA.Text = Convert.ToString(_rowIndex);
            VLA.Text = Convert.ToString(_value);
        }

        private void pravaButton_Click(object sender, EventArgs e)
        {
            pravaPanel.Visible = true;
            banPanel.Visible = true;
            dbTable.Visible = false;
            IPA.Visible = false;

            pravaButton.FlatAppearance.BorderSize = 0;

            DatabaseManager db = new();
            List<string> users = db.UserList();

            FillBox(users, usersBox);
            FillBox(users, userBox);
            FillBox(prava, pravaBox);

        }

        private void FillBox(List<string> list, ComboBox box)
        {
            box.Items.Clear();

            foreach (string item in list)
            {
                box.Items.Add(item);
            }
        }

        private void changePrava_Click(object sender, EventArgs e)
        {
            string username = usersBox.SelectedItem.ToString();
            string dostup = pravaBox.SelectedItem.ToString();

            try
            {
                DatabaseManager db = new();
                db.ChangePrava(dostup, username);

                MessageBox.Show("Успешно");

                usersBox.SelectedIndex = -1;
                pravaBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            string username = userBox.SelectedItem.ToString();

            try
            {
                DatabaseManager db = new();
                db.UserBan(username);

                MessageBox.Show("Успешно");

                userBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitSeans_Click(object sender, EventArgs e)
        {

        }
    }
}
