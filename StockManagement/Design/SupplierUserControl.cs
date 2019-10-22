using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Model;
using StockManagement.Manager;

namespace StockManagement.Design
{
    public partial class SupplierUserControl : UserControl
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier;

        public SupplierUserControl()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _supplier = new Supplier(codeTextBox.Text, nameTextBox.Text, addressTextBox.Text, contactTextBox.Text, emailTextBox.Text, contactPersonTextBox.Text);

            if (_supplierManager.AddSupplier(_supplier))
            {
                showDataGridView.DataSource = _supplierManager.Display();
                MessageBox.Show("Suppler Added Successfully..!", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Supplier Added Failed!", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
