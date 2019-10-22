using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Design
{
    public partial class StockUserControl : UserControl
    {
        public StockUserControl()
        {
            InitializeComponent();
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

        
    }
}
