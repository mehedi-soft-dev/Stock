using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using StockManagement.Model;
using StockManagement.Manager;

namespace StockManagement.Design
{
    public partial class SalesUserControl : UserControl
    {
        CusotmerManager _cusotmerManager = new CusotmerManager();
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        PurchaseManager _purchaseManager = new PurchaseManager();

        List<Sale> _saleList = new List<Sale>();

        public SalesUserControl()
        {
            InitializeComponent();
            customerComboBox.DataSource = _cusotmerManager.CustomerComboItem();
            categoryComboBox.DataSource = _categoryManager.CategoryComboItem();
            productComboBox.DataSource = _productManager.GetProductsByCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(Convert.ToDateTime(saleDatePicker.Value), Convert.ToInt32(customerComboBox.SelectedValue), Convert.ToInt32(productComboBox.SelectedValue), Convert.ToInt32(quantityTextBox.Text), Convert.ToDouble(MRPTextBox.Text));
            _saleList.Add(sale);

            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _saleList;
            grandTotalTextBox.Text = GetGrandTotal(_saleList).ToString();

        }

        private double GetGrandTotal(List<Sale> sales)
        {
            double grandTotal = 0;
            foreach (Sale sale in sales)
            {
                grandTotal += sale.Quantity * sale.Price;
            }
            return grandTotal;
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource =
                _productManager.GetProductsByCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
        }

        private Purchase purchase;
        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
             purchase = _purchaseManager.LastPurchaseInfo(Convert.ToInt32(productComboBox.SelectedValue));

            availableQuantityTextBox.Text =
                _purchaseManager.AvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue)).ToString();

            MRPTextBox.Text = purchase.MRP.ToString();
            quantityTextBox.ResetText();
            totalMRPTextBox.ResetText();

        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text))
            {
                totalMRPTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * purchase.MRP).ToString();
            }
        }
    }
}
