using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Manager;

namespace StockManagement.Design
{
    public partial class StockUserControl : UserControl
    {
        StockManager _stockManager = new StockManager();

        public StockUserControl()
        {
            InitializeComponent();
            showDataGridView.DataSource = _stockManager.FullStocks();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void startDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            startDatePicker.CustomFormat = "--/--/----";
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void endDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            endDatePicker.CustomFormat = "--/--/----";
        }

        private void dateSearchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _stockManager.StocksByDate(Convert.ToDateTime(startDatePicker.Text),
                Convert.ToDateTime(endDatePicker.Text));
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _stockManager.Search(searchTextBox.Text);
        }
    }
}
