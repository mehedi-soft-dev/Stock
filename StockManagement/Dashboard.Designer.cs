namespace StockManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.reportsButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.exitButton = new Guna.UI.WinForms.GunaButton();
            this.minimizeButton = new Guna.UI.WinForms.GunaButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.sidePanel.Controls.Add(this.sideBarPanel);
            this.sidePanel.Controls.Add(this.reportsButton);
            this.sidePanel.Controls.Add(this.stockOutButton);
            this.sidePanel.Controls.Add(this.stockButton);
            this.sidePanel.Controls.Add(this.saleButton);
            this.sidePanel.Controls.Add(this.orderButton);
            this.sidePanel.Controls.Add(this.customerButton);
            this.sidePanel.Controls.Add(this.supplierButton);
            this.sidePanel.Controls.Add(this.purchaseButton);
            this.sidePanel.Controls.Add(this.productButton);
            this.sidePanel.Controls.Add(this.categoryButton);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(168, 600);
            this.sidePanel.TabIndex = 1;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.White;
            this.sideBarPanel.Location = new System.Drawing.Point(2, 157);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(6, 30);
            this.sideBarPanel.TabIndex = 4;
            // 
            // reportsButton
            // 
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsButton.Image")));
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(12, 527);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(153, 35);
            this.reportsButton.TabIndex = 8;
            this.reportsButton.Text = "        Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // stockOutButton
            // 
            this.stockOutButton.FlatAppearance.BorderSize = 0;
            this.stockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockOutButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutButton.ForeColor = System.Drawing.Color.White;
            this.stockOutButton.Image = ((System.Drawing.Image)(resources.GetObject("stockOutButton.Image")));
            this.stockOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.Location = new System.Drawing.Point(12, 491);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(153, 35);
            this.stockOutButton.TabIndex = 7;
            this.stockOutButton.Text = "        Stock Out";
            this.stockOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.UseVisualStyleBackColor = true;
            // 
            // stockButton
            // 
            this.stockButton.FlatAppearance.BorderSize = 0;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.ForeColor = System.Drawing.Color.White;
            this.stockButton.Image = ((System.Drawing.Image)(resources.GetObject("stockButton.Image")));
            this.stockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.Location = new System.Drawing.Point(12, 455);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(153, 35);
            this.stockButton.TabIndex = 6;
            this.stockButton.Text = "        Stock";
            this.stockButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.FlatAppearance.BorderSize = 0;
            this.saleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.ForeColor = System.Drawing.Color.White;
            this.saleButton.Image = ((System.Drawing.Image)(resources.GetObject("saleButton.Image")));
            this.saleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.Location = new System.Drawing.Point(12, 419);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(153, 35);
            this.saleButton.TabIndex = 5;
            this.saleButton.Text = "        Sale";
            this.saleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.Location = new System.Drawing.Point(12, 383);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(153, 35);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "        Order Product";
            this.orderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(9, 267);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(153, 35);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "        Customer";
            this.customerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.FlatAppearance.BorderSize = 0;
            this.supplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierButton.ForeColor = System.Drawing.Color.White;
            this.supplierButton.Image = ((System.Drawing.Image)(resources.GetObject("supplierButton.Image")));
            this.supplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierButton.Location = new System.Drawing.Point(12, 307);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(153, 35);
            this.supplierButton.TabIndex = 3;
            this.supplierButton.Text = "        Supplier";
            this.supplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.FlatAppearance.BorderSize = 0;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.ForeColor = System.Drawing.Color.White;
            this.purchaseButton.Image = ((System.Drawing.Image)(resources.GetObject("purchaseButton.Image")));
            this.purchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.Location = new System.Drawing.Point(12, 347);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(153, 35);
            this.purchaseButton.TabIndex = 3;
            this.purchaseButton.Text = "        Purchase";
            this.purchaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // productButton
            // 
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.ForeColor = System.Drawing.Color.White;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(12, 227);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(153, 35);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "        Product";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(12, 191);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(153, 35);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "        Category";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(12, 155);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(153, 35);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "        Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AnimationHoverSpeed = 0.07F;
            this.exitButton.AnimationSpeed = 0.03F;
            this.exitButton.BaseColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FocusedColor = System.Drawing.Color.Empty;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.Turquoise;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.exitButton.Location = new System.Drawing.Point(857, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.exitButton.OnHoverImage = null;
            this.exitButton.OnPressedColor = System.Drawing.Color.Black;
            this.exitButton.Size = new System.Drawing.Size(22, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AnimationHoverSpeed = 0.07F;
            this.minimizeButton.AnimationSpeed = 0.03F;
            this.minimizeButton.BaseColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.Black;
            this.minimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.Turquoise;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.minimizeButton.Location = new System.Drawing.Point(835, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.minimizeButton.OnHoverImage = null;
            this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.minimizeButton.Size = new System.Drawing.Size(22, 23);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(168, 29);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(881, 570);
            this.contentPanel.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(168, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(882, 30);
            this.topPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management System V1.0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button dashboardButton;
        private Guna.UI.WinForms.GunaButton exitButton;
        private Guna.UI.WinForms.GunaButton minimizeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Label label1;
    }
}

