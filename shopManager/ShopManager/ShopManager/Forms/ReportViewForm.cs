using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace ShopManager.Forms
{
    public partial class ReportViewForm : Form
    {
        public ReportViewForm(string reportTitle, DataTable reportData, decimal totalAmount = 0)
        {
            InitializeComponent();
            this.Text = reportTitle;
            dataGridViewReport.DataSource = reportData;
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReport.ReadOnly = true;

            allPrice.Text = totalAmount > 0 ? totalAmount.ToString("C", CultureInfo.GetCultureInfo("ru-RU")) : "0,00 ₽";

            dataGridViewReport.CellFormatting += DataGridViewReport_CellFormatting;

            ConfigureReportLayout(reportTitle);
        }

        private void ConfigureReportLayout(string reportTitle)
        {
            if (reportTitle == "Отчет о продажах")
            {
                lblTitle.Text = "Итого:";
                lblTitle.Visible = true;
                allPrice.Visible = true;
            }
            else if (reportTitle == "Отчет по инвентаризации")
            {
                lblTitle.Text = "Товаров на сумму:";
                lblTitle.Visible = true;
                allPrice.Visible = true;
            }
            else
            {
                lblTitle.Visible = false;
                allPrice.Visible = false;
            }
        }

        private void DataGridViewReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewReport.Rows.Count) return;

            string quantityColumnName = "StockQuantity";
            if (dataGridViewReport.Columns.Contains(quantityColumnName))
            {
                DataGridViewRow row = dataGridViewReport.Rows[e.RowIndex];
                object quantityValue = row.Cells[quantityColumnName].Value;

                if (quantityValue != null && quantityValue != DBNull.Value &&
                    int.TryParse(quantityValue.ToString(), out int quantity) && quantity == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridViewReport.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dataGridViewReport.DefaultCellStyle.ForeColor;
                }
            }
        }
    }
}