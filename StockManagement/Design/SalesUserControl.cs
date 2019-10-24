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
        SaleManager _saleManager = new SaleManager();
        Customer _customer = new Customer();

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
            try
            {
                if(!IsValid())
                    return;

                Sale sale = new Sale();
                sale.Date = Convert.ToDateTime(saleDatePicker.Value);
                sale.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
                sale.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
                sale.Quantity = Convert.ToInt32(quantityTextBox.Text);
                sale.Price = Convert.ToDouble(priceTextBox.Text);
                sale.DiscountPercentage = Convert.ToDouble(discountPercentageTextBox.Text);

                _saleList.Add(sale);

                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _saleList;

                grandTotalTextBox.Text = GetGrandTotal(_saleList).ToString();
                discountPercentageTextBox.Text = (_customer.LoyalityPoint / 10).ToString();
                discountAmountTextBox.Text =
                    ((Convert.ToInt32(grandTotalTextBox.Text) * Convert.ToInt32(discountPercentageTextBox.Text)) / 100)
                    .ToString();
                payableAmountTextBox.Text =
                    (Convert.ToDouble(grandTotalTextBox.Text) - Convert.ToDouble(discountAmountTextBox.Text))
                    .ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool IsValid()
        {
            if (Convert.ToInt32(customerComboBox.SelectedValue) == 0)
            {
                customerErrorLabel.Text = "Please Select Customer";
                return false;
            }
            else
                customerErrorLabel.ResetText();

            if (Convert.ToInt32(categoryComboBox.SelectedValue) == 0)
            {
                categoryErrorLabel.Text = "Please Select Category";
                return false;
            }
            else
                categoryErrorLabel.ResetText();

            if (Convert.ToInt32(productComboBox.SelectedValue) == 0)
            {
                productErrorLabel.Text = "Please Select Product";
                return false;
            }
            else
                productErrorLabel.ResetText();

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityErrorLabel.Text = "Please Enter Quantity";
                return false;
            }
            else
                quantityErrorLabel.ResetText();

            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                quantityErrorLabel.Text = "Please Enter Price";
                return false;
            }
            else
                quantityErrorLabel.ResetText();

            return true;
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

        private Purchase _purchase;
        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
             _purchase = _purchaseManager.LastPurchaseInfo(Convert.ToInt32(productComboBox.SelectedValue));

            availableQuantityTextBox.Text =
                _purchaseManager.AvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue)).ToString();

            priceTextBox.Text = _purchase.MRP.ToString();
            quantityTextBox.ResetText();
            totalMRPTextBox.ResetText();

        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityErrorLabel.ResetText();
                totalMRPTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * _purchase.MRP).ToString();
            }
            else
            {
                totalMRPTextBox.ResetText();
            }
        }

        private void customerComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customer = _cusotmerManager.SearchById(Convert.ToInt32(customerComboBox.SelectedValue));
                loyalityPointTextBox.Text = _customer.LoyalityPoint.ToString();
                customerErrorLabel.ResetText();

                _saleList.Clear();
                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _saleList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (_saleManager.AddSale(_saleList))
                MessageBox.Show("Successfully sold..!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Failed..!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
