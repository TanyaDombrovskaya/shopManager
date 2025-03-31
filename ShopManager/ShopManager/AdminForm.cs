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
        private int _rowIndex;
        private int _colIndex;
        private string _value;

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


        public void BaseValueSettings()
        {
            colIndexLabel.Text = "1";
            rowIndexLabel.Text = "1";

            valueLabel.Text = Convert.ToString(dbTable.Rows[0].Cells[0].Value);
            valueLabel.Text = Convert.ToString(dbTable.Rows[0].Cells[0].Value);
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
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;

            tableNameLabel.Text = table;

            BaseValueSettings();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string table = "orders";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;

            tableNameLabel.Text = table;

            BaseValueSettings();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            string table = "categories";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;

            tableNameLabel.Text = table;

            BaseValueSettings();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            string table = "products";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            settingsPanel.Visible = false;
            dbPanel.Visible = true;

            tableNameLabel.Text = table;

            BaseValueSettings();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            string table = "users";

            DatabaseManager db = new();
            db.LoadTable(dbTable, table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);
            dbTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dbTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dbTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            settingsPanel.Visible = false;
            dbPanel.Visible = true;

            tableNameLabel.Text = table;

            BaseValueSettings();
        }

        private void dbTable_CellClick(object sender, DataGridViewCellEventArgs e)
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

            colIndexLabel.Text = Convert.ToString(_colIndex);
            rowIndexLabel.Text = Convert.ToString(_rowIndex);
            valueLabel.Text = Convert.ToString(_value);
        }
    }
}
