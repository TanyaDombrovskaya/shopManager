using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public static class GlobalID
    {
        private const string filePath = "userId.txt";

        public static int ID { get; set; }

        public static void WriteID()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.WriteAllText(filePath, Convert.ToString(ID));
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public static int ReadID()
        {
            string id = string.Empty;

            try
            {
                id = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении ID из файла: {ex.Message}");
                return 0; 
            }

            return Convert.ToInt32(id);
        }

        public static void ClearID()
        {
            ID = 0;

            try
            {
                if (File.Exists(filePath))
                {
                    File.WriteAllText(filePath, Convert.ToString(ID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
