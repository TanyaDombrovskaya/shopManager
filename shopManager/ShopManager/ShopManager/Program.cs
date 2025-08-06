using ShopManager.Forms;
using System;
using System.Windows.Forms;

namespace ShopManager
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ������������� ���� ������
            Data.DatabaseManager.InitializeDatabase();

            // ������ ����� �����
            Application.Run(new LoginForm());
        }
    }
}