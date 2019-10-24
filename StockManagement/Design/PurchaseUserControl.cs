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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValid())
                    return;

                Purchase purchase = new Purchase();

                if (manufacturedDatePicker.Text == "--/--/----")
                    purchase.ManufactureDate = null;
                else
                    purchase.ManufactureDate = Convert.ToDateTime(manufacturedDatePicker.Text);

                if (expireDatePicker.Text == "--/--/----")
                    purchase.ExpireDate = null;
                else
                    purchase.ExpireDate = Convert.ToDateTime(expireDatePicker.Text);

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

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_purchaseList.Count == 0)
                {
                    MessageBox.Show("Please Add Item First...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
                DialogResult dialogResult = MessageBox.Show("Do you want to Confirm Purchase?\n\nClick YES to Confirm Purchase.", "Confirm Purchase",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_purchaseManager.AddPurchase(_purchaseList))
                    {
                        _purchaseList.Clear();
                        showDataGridView.DataSource = null;
                        MessageBox.Show("Purchase Successfully..!", "Purchase Product", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Purchase Failed..!", "Purchase Product", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Reset()
        {
            categoryComboBox.SelectedValue = 0;
            manufacturedDatePicker.CustomFormat = "--/--/----";
            expireDatePicker.CustomFormat = "--/--/----";
            quantityTextBox.ResetText();
            unitPriceTextBox.ResetText();
            totalPriceTextBox.ResetText();
            MRPTextBox.ResetText();
            remarkTextBox.ResetText();
        }

        private bool IsValid()
        {
            if (String.IsNullOrEmpty(invoiceNoTextBox.Text))
            {
                invoiceNoErrorLabel.Text = "Please Enter Invoice/Bill No";
                return false;
            }
            else
                invoiceNoErrorLabel.ResetText();
            

            if (Convert.ToInt32(supplierComboBox.SelectedValue) == 0)
            {
                supplierErrorLabel.Text = "Please Select Supplier";
                return false;
            }
            else
                supplierErrorLabel.ResetText();

            if(Convert.ToInt32(categoryComboBox.SelectedValue) == 0)
            {
                categoryErrorLabel.Text = "Please Select Category";
                return false;
            }
            else
                supplierErrorLabel.ResetText();

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

            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                unitPriceErrorLabel.Text = "Please Enter Unit Price";
                return false;
            }
            else
                unitPriceErrorLabel.ResetText();

            if (String.IsNullOrEmpty(MRPTextBox.Text))
            {
                MRPErrorLabel.Text = "Please Enter M.R.P (Tk.)";
                return false;
            }
            else
                MRPErrorLabel.ResetText();


            return true;
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

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource = _productManager.GetProductsByCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
            categoryErrorLabel.ResetText();
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

            productErrorLabel.ResetText();
        }

        private void unitPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
                MRPTextBox.Text = (Convert.ToDouble(unitPriceTextBox.Text) + (Convert.ToDouble(unitPriceTextBox.Text) * 25) / 100).ToString();
            }
            else
            {
                totalPriceTextBox.ResetText();
            }

            if(!String.IsNullOrEmpty(unitPriceTextBox.Text))
                unitPriceErrorLabel.ResetText();
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

            if(!String.IsNullOrEmpty(quantityTextBox.Text))
                quantityErrorLabel.ResetText();
        }

        private void invoiceNoTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(invoiceNoTextBox.Text))
            {
                invoiceNoErrorLabel.ResetText();
            }
        }

        private void supplierComboBox_TextChanged(object sender, EventArgs e)
        {
            supplierErrorLabel.ResetText();
        }

        private void MRPTextBox_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(MRPTextBox.Text))
                MRPErrorLabel.ResetText();
        }
    }
}
