using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Design;
using StockManagement.Model;

namespace StockManagement
{
    public partial class Dashboard : Form
    {
        Category category = new Category();

        public Dashboard()
        {
            InitializeComponent();
            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ShowControl(dashboardUserControl);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = dashboardButton.Height;
            sideBarPanel.Top = dashboardButton.Top;
            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ShowControl(dashboardUserControl);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = categoryButton.Height;
            sideBarPanel.Top = categoryButton.Top;

            CategoryUserControl categoryUserControl = new CategoryUserControl();
            ShowControl(categoryUserControl);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Exit ?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = productButton.Height;
            sideBarPanel.Top = productButton.Top;

            ProductUserControl productUserControl = new ProductUserControl();
            ShowControl(productUserControl);
        }

        private void ShowControl(Control control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            contentPanel.Controls.Add(control);
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = customerButton.Height;
            sideBarPanel.Top = customerButton.Top;

            CustomerUserControl customerUserControl = new CustomerUserControl();
            ShowControl(customerUserControl);
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = supplierButton.Height;
            sideBarPanel.Top = supplierButton.Top;

            SupplierUserControl supplierUserControl = new SupplierUserControl();
            ShowControl(supplierUserControl);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = purchaseButton.Height;
            sideBarPanel.Top = purchaseButton.Top;

            PurchaseUserControl purchaseUserControl = new PurchaseUserControl();
            ShowControl(purchaseUserControl);
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = saleButton.Height;
            sideBarPanel.Top = saleButton.Top;

            SalesUserControl salesUserControl = new SalesUserControl();
            ShowControl(salesUserControl);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = orderButton.Height;
            sideBarPanel.Top = orderButton.Top;

            OrderProductUserControl orderPurchaseUserControl = new OrderProductUserControl();
            ShowControl(orderPurchaseUserControl);
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = stockButton.Height;
            sideBarPanel.Top = stockButton.Top;

            StockUserControl stockUserControl = new StockUserControl();
            ShowControl(stockUserControl);
        }
    }
}
