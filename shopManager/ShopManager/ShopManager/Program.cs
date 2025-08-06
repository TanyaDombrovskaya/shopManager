using ShopManager.Forms;
using System;
using System.Windows.Forms;

namespace ShopManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Инициализация базы данных
            Data.DatabaseManager.InitializeDatabase();

            // Запуск формы входа
            Application.Run(new LoginForm());
        }
    }
}