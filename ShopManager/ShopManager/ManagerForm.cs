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
    public partial class ManagerForm : Base
    {
        private Point lastMousePosition;
        public List<Button> _buttonsMain = new List<Button>();
        public List<Button> _buttonsControl = new List<Button>();
        private string _table;
        private int _rowIndex;
        private int _colIndex;
        private string _value;
        private bool _flag = false;

        public ManagerForm()
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
            dbTable.Parent = dbPanel;
        }

        public string NameManager
        {
            get { return nameManager.Text; }
            set { nameManager.Text = value; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeBorder()
        {
            productsButton.FlatAppearance.BorderSize = 0;
            categoriesButton.FlatAppearance.BorderSize = 0;
            orderButton.FlatAppearance.BorderSize = 0;
            detailsButtons.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.BorderSize = 0;
            zaprosButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.BorderSize = 0;
        }

        private void AddButtonsDB()
        {
            _buttonsMain.Add(productsButton);
            _buttonsMain.Add(categoriesButton);
            _buttonsMain.Add(orderButton);
            _buttonsMain.Add(detailsButtons);
            _buttonsMain.Add(exitButton);
        }

        private void AddButtonsControl()
        {
            _buttonsControl.Add(addButton);
            _buttonsControl.Add(deleteButton);
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

        private void detailsButtons_Click(object sender, EventArgs e)
        {
            _table = "orderDetails";

            DatabaseManager db = new();
            db.LoadTable(dbTable, _table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            dbPanel.Visible = true;

            tableNameLabel.Text = _table;

            BaseValueSettings();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            _table = "orders";

            DatabaseManager db = new();
            db.LoadTable(dbTable, _table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            dbPanel.Visible = true;

            tableNameLabel.Text = _table;

            BaseValueSettings();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            _table = "categories";

            DatabaseManager db = new();
            db.LoadTable(dbTable, _table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            dbPanel.Visible = true;

            tableNameLabel.Text = _table;

            BaseValueSettings();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            _table = "products";

            DatabaseManager db = new();
            db.LoadTable(dbTable, _table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);

            dbPanel.Visible = true;

            tableNameLabel.Text = _table;

            BaseValueSettings();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            _table = "users";

            DatabaseManager db = new();
            db.LoadTable(dbTable, _table);
            dbTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 61, 235);
            dbTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dbTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dbTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dbPanel.Visible = true;

            tableNameLabel.Text = _table;

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

        private void changeValueButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            valueInput.Visible = true;
            changeButtonEnd.Visible = true;

            valueInput.Text = _value;
        }

        private void changeButtonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new();

                string newValue = valueInput.Text;

                db.ChangeValue(_table, _colIndex, _value, newValue);

                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hideSetPanel_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void rebootTable_Click(object sender, EventArgs e)
        {
            DatabaseManager db = new();

            db.LoadTable(dbTable, _table);

            _colIndex = 1;
            _rowIndex = 1;
            _value = Convert.ToString(dbTable.Rows[_rowIndex - 1].Cells[_colIndex - 1].Value);

            colIndexLabel.Text = Convert.ToString(_colIndex);
            rowIndexLabel.Text = Convert.ToString(_rowIndex);
            valueLabel.Text = Convert.ToString(_value);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем экземпляр DatabaseHelper с вашей строкой подключения
                DatabaseManager db = new();

                // Вызываем метод для добавления пустой строки в указанную таблицу
                db.InsertEmptyRow(_table);

                // Вы можете добавить код для обновления интерфейса или уведомления пользователя
                MessageBox.Show("Пустая строка успешно добавлена.");
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при добавлении строки: {ex.Message}");
            }
        }

        public void FillBox(ComboBox box)
        {
            DatabaseManager db = new();
            int count = db.GetRowsCount(_table);

            box.Items.Clear();

            for (int i = 1; i < count + 1; i++)
            {
                box.Items.Add(i);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            delRowsButton.Visible = true;
            rowsIdBox.Visible = true;

            FillBox(rowsIdBox);
        }

        private void delRowsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new();
                int id = Convert.ToInt32(rowsIdBox.SelectedItem);
                db.DeleteRow(_table, id);

                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
