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
    public partial class PurchaseUserControl : UserControl
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        SupplierManager _supplierManager = new SupplierManager();
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();

        List<Purchase> _purchaseList = new List<Purchase>();

        private Product product;

        public PurchaseUserControl()
        {
            InitializeComponent();
            supplierComboBox.DataSource = _supplierManager.SupplierComboItem();
            categoryComboBox.DataSource = _categoryManager.CategoryComboItem();
        }

        private void manufacturedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            manufacturedDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void manufacturedDatePicker_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                manufacturedDatePicker.CustomFormat = "--/--/----";
        }

        private void expireDatePicker_ValueChanged(object sender, EventArgs e)
        {
            expireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void expireDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                expireDatePicker.CustomFormat = "--/--/----";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();

            purchase.Date = Convert.ToDateTime(purchaseDatePicker.Text);
            purchase.InvoiceNo = invoiceNoTextBox.Text;
            purchase.SupplierID = Convert.ToInt32(supplierComboBox.SelectedValue);
            purchase.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
            purchase.Quantity = Convert.ToInt32(quantityTextBox.Text);
            purchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            purchase.MRP = Convert.ToDouble(MRPTextBox.Text);

            _purchaseList.Add(purchase);

            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _purchaseList;

            totalItemLabel.Text = _purchaseList.Count().ToString();
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource = _productManager.GetProductsByCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(productComboBox.SelectedValue) > 0)
            {
                product = _productManager.SearchProductById(Convert.ToInt32(productComboBox.SelectedValue));
                Purchase purchase = _purchaseManager.LastPurchaseInfo(Convert.ToInt32(productComboBox.SelectedValue));
                int qty = _purchaseManager.AvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue));

                codeTextBox.Text = product.Code;
                previousUnitPriceTextBox.Text = purchase.UnitPrice.ToString();
                previousMRPTextBox.Text = purchase.MRP.ToString();
                availableQuantityTextBox.Text = qty.ToString();
            }
            else
            {
                codeTextBox.ResetText();
                availableQuantityTextBox.ResetText();
                previousUnitPriceTextBox.ResetText();
                previousMRPTextBox.ResetText();
            }
            

        }

        private void unitPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
            }
            else
            {
                totalPriceTextBox.ResetText();
            }
        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
            }
            else
            {
                totalPriceTextBox.ResetText();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (_purchaseManager.AddPurchase(_purchaseList))
            {
                MessageBox.Show("Purchase Successfully..!", "Purchase Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Purchase Failed..!", "Purchase Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
