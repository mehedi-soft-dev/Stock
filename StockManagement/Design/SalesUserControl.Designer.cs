namespace StockManagement.Design
{
    partial class SalesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.loyalityPointTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.purchaseDateErrorlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new Guna.UI.WinForms.GunaButton();
            this.totalMRPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MRPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.quantityTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.productErrorLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.submitButton = new Guna.UI.WinForms.GunaButton();
            this.payableAmountTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.discountAmountTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.discountPercentageTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.grandTotalTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.showDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.purchaseDatePicker);
            this.groupBox1.Controls.Add(this.loyalityPointTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerErrorLabel);
            this.groupBox1.Controls.Add(this.purchaseDateErrorlabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDatePicker.Location = new System.Drawing.Point(109, 34);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(175, 25);
            this.purchaseDatePicker.TabIndex = 3;
            this.purchaseDatePicker.Value = new System.DateTime(2019, 10, 17, 0, 0, 0, 0);
            // 
            // loyalityPointTextBox
            // 
            this.loyalityPointTextBox.BaseColor = System.Drawing.Color.White;
            this.loyalityPointTextBox.BorderColor = System.Drawing.Color.Silver;
            this.loyalityPointTextBox.BorderSize = 1;
            this.loyalityPointTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loyalityPointTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.loyalityPointTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.loyalityPointTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.loyalityPointTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loyalityPointTextBox.Location = new System.Drawing.Point(111, 116);
            this.loyalityPointTextBox.Name = "loyalityPointTextBox";
            this.loyalityPointTextBox.PasswordChar = '\0';
            this.loyalityPointTextBox.Size = new System.Drawing.Size(173, 26);
            this.loyalityPointTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loyality Point";
            // 
            // customerComboBox
            // 
            this.customerComboBox.BackColor = System.Drawing.Color.Transparent;
            this.customerComboBox.BaseColor = System.Drawing.Color.White;
            this.customerComboBox.BorderColor = System.Drawing.Color.Silver;
            this.customerComboBox.BorderSize = 1;
            this.customerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.customerComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customerComboBox.ForeColor = System.Drawing.Color.Black;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(109, 71);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.customerComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.customerComboBox.Size = new System.Drawing.Size(175, 26);
            this.customerComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.customerErrorLabel.Location = new System.Drawing.Point(107, 100);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(119, 13);
            this.customerErrorLabel.TabIndex = 1;
            this.customerErrorLabel.Text = "Please Select Customer";
            // 
            // purchaseDateErrorlabel
            // 
            this.purchaseDateErrorlabel.AutoSize = true;
            this.purchaseDateErrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.purchaseDateErrorlabel.Location = new System.Drawing.Point(108, 58);
            this.purchaseDateErrorlabel.Name = "purchaseDateErrorlabel";
            this.purchaseDateErrorlabel.Size = new System.Drawing.Size(119, 13);
            this.purchaseDateErrorlabel.TabIndex = 1;
            this.purchaseDateErrorlabel.Text = "Please Enter Valid Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.totalMRPTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.MRPTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.categoryErrorLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.quantityErrorLabel);
            this.groupBox2.Controls.Add(this.productErrorLabel);
            this.groupBox2.Location = new System.Drawing.Point(21, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // addButton
            // 
            this.addButton.AnimationHoverSpeed = 0.07F;
            this.addButton.AnimationSpeed = 0.03F;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.addButton.BorderColor = System.Drawing.Color.Black;
            this.addButton.FocusedColor = System.Drawing.Color.Empty;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = null;
            this.addButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addButton.Location = new System.Drawing.Point(159, 266);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addButton.OnHoverImage = null;
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Radius = 15;
            this.addButton.Size = new System.Drawing.Size(125, 34);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalMRPTextBox
            // 
            this.totalMRPTextBox.BaseColor = System.Drawing.Color.White;
            this.totalMRPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.totalMRPTextBox.BorderSize = 1;
            this.totalMRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalMRPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.totalMRPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.totalMRPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.totalMRPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalMRPTextBox.Location = new System.Drawing.Point(109, 220);
            this.totalMRPTextBox.Name = "totalMRPTextBox";
            this.totalMRPTextBox.PasswordChar = '\0';
            this.totalMRPTextBox.Size = new System.Drawing.Size(175, 26);
            this.totalMRPTextBox.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total MRP (Tk.)";
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.BaseColor = System.Drawing.Color.White;
            this.MRPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.MRPTextBox.BorderSize = 1;
            this.MRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MRPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.MRPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.MRPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.MRPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MRPTextBox.Location = new System.Drawing.Point(109, 179);
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.PasswordChar = '\0';
            this.MRPTextBox.Size = new System.Drawing.Size(175, 26);
            this.MRPTextBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "MRP (Tk.)";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BaseColor = System.Drawing.Color.White;
            this.quantityTextBox.BorderColor = System.Drawing.Color.Silver;
            this.quantityTextBox.BorderSize = 1;
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.quantityTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.quantityTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityTextBox.Location = new System.Drawing.Point(109, 138);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.Size = new System.Drawing.Size(175, 26);
            this.quantityTextBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quantity";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.BaseColor = System.Drawing.Color.White;
            this.availableQuantityTextBox.BorderColor = System.Drawing.Color.Silver;
            this.availableQuantityTextBox.BorderSize = 1;
            this.availableQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.availableQuantityTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.availableQuantityTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.availableQuantityTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.availableQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.availableQuantityTextBox.Location = new System.Drawing.Point(109, 99);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.PasswordChar = '\0';
            this.availableQuantityTextBox.Size = new System.Drawing.Size(175, 26);
            this.availableQuantityTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Available Quantity";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryComboBox.BaseColor = System.Drawing.Color.White;
            this.categoryComboBox.BorderColor = System.Drawing.Color.Silver;
            this.categoryComboBox.BorderSize = 1;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(109, 19);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.categoryComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.categoryComboBox.Size = new System.Drawing.Size(175, 26);
            this.categoryComboBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Category";
            // 
            // productComboBox
            // 
            this.productComboBox.BackColor = System.Drawing.Color.Transparent;
            this.productComboBox.BaseColor = System.Drawing.Color.White;
            this.productComboBox.BorderColor = System.Drawing.Color.Silver;
            this.productComboBox.BorderSize = 1;
            this.productComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productComboBox.ForeColor = System.Drawing.Color.Black;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(109, 59);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.productComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.productComboBox.Size = new System.Drawing.Size(175, 26);
            this.productComboBox.TabIndex = 2;
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryErrorLabel.Location = new System.Drawing.Point(107, 44);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(119, 13);
            this.categoryErrorLabel.TabIndex = 1;
            this.categoryErrorLabel.Text = "Please Select Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(108, 163);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(109, 13);
            this.quantityErrorLabel.TabIndex = 1;
            this.quantityErrorLabel.Text = "Please Enter Quantity";
            // 
            // productErrorLabel
            // 
            this.productErrorLabel.AutoSize = true;
            this.productErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.productErrorLabel.Location = new System.Drawing.Point(107, 84);
            this.productErrorLabel.Name = "productErrorLabel";
            this.productErrorLabel.Size = new System.Drawing.Size(119, 13);
            this.productErrorLabel.TabIndex = 1;
            this.productErrorLabel.Text = "Please Select Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.submitButton);
            this.groupBox3.Controls.Add(this.payableAmountTextBox);
            this.groupBox3.Controls.Add(this.gunaLabel4);
            this.groupBox3.Controls.Add(this.discountAmountTextBox);
            this.groupBox3.Controls.Add(this.gunaLabel3);
            this.groupBox3.Controls.Add(this.discountPercentageTextBox);
            this.groupBox3.Controls.Add(this.gunaLabel2);
            this.groupBox3.Controls.Add(this.grandTotalTextBox);
            this.groupBox3.Controls.Add(this.gunaLabel1);
            this.groupBox3.Controls.Add(this.showDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(361, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 478);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details";
            // 
            // submitButton
            // 
            this.submitButton.AnimationHoverSpeed = 0.07F;
            this.submitButton.AnimationSpeed = 0.03F;
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.submitButton.BorderColor = System.Drawing.Color.Black;
            this.submitButton.FocusedColor = System.Drawing.Color.Empty;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Image = null;
            this.submitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.submitButton.Location = new System.Drawing.Point(330, 425);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.submitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.submitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.submitButton.OnHoverImage = null;
            this.submitButton.OnPressedColor = System.Drawing.Color.Black;
            this.submitButton.Radius = 15;
            this.submitButton.Size = new System.Drawing.Size(125, 34);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.BaseColor = System.Drawing.Color.White;
            this.payableAmountTextBox.BorderColor = System.Drawing.Color.Silver;
            this.payableAmountTextBox.BorderSize = 1;
            this.payableAmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.payableAmountTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.payableAmountTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.payableAmountTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.payableAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payableAmountTextBox.Location = new System.Drawing.Point(318, 351);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.PasswordChar = '\0';
            this.payableAmountTextBox.Size = new System.Drawing.Size(137, 26);
            this.payableAmountTextBox.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(206, 359);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(95, 15);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Payable Amount";
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.BaseColor = System.Drawing.Color.White;
            this.discountAmountTextBox.BorderColor = System.Drawing.Color.Silver;
            this.discountAmountTextBox.BorderSize = 1;
            this.discountAmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountAmountTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.discountAmountTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.discountAmountTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.discountAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discountAmountTextBox.Location = new System.Drawing.Point(318, 319);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.PasswordChar = '\0';
            this.discountAmountTextBox.Size = new System.Drawing.Size(137, 26);
            this.discountAmountTextBox.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(200, 325);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(101, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Discount Amount";
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.BaseColor = System.Drawing.Color.White;
            this.discountPercentageTextBox.BorderColor = System.Drawing.Color.Silver;
            this.discountPercentageTextBox.BorderSize = 1;
            this.discountPercentageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountPercentageTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.discountPercentageTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.discountPercentageTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.discountPercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discountPercentageTextBox.Location = new System.Drawing.Point(318, 287);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.PasswordChar = '\0';
            this.discountPercentageTextBox.Size = new System.Drawing.Size(137, 26);
            this.discountPercentageTextBox.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(220, 294);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Discount ( % )";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.BaseColor = System.Drawing.Color.White;
            this.grandTotalTextBox.BorderColor = System.Drawing.Color.Silver;
            this.grandTotalTextBox.BorderSize = 1;
            this.grandTotalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grandTotalTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.grandTotalTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.grandTotalTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.grandTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grandTotalTextBox.Location = new System.Drawing.Point(318, 255);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.PasswordChar = '\0';
            this.grandTotalTextBox.Size = new System.Drawing.Size(137, 26);
            this.grandTotalTextBox.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(234, 261);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Grand Total";
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.showDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.showDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showDataGridView.ColumnHeadersHeight = 21;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.showDataGridView.EnableHeadersVisualStyles = false;
            this.showDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.showDataGridView.Location = new System.Drawing.Point(6, 36);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.RowHeadersVisible = false;
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(489, 195);
            this.showDataGridView.TabIndex = 1;
            this.showDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.showDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.showDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.showDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.showDataGridView.ThemeStyle.ReadOnly = true;
            this.showDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.showDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.showDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.showDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.showDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // SalesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesUserControl";
            this.Size = new System.Drawing.Size(881, 570);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
        private Guna.UI.WinForms.GunaTextBox loyalityPointTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox customerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerErrorLabel;
        private System.Windows.Forms.Label purchaseDateErrorlabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox quantityTextBox;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox availableQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox categoryComboBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox productComboBox;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label productErrorLabel;
        private Guna.UI.WinForms.GunaTextBox totalMRPTextBox;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox MRPTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaDataGridView showDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private Guna.UI.WinForms.GunaTextBox grandTotalTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton addButton;
        private Guna.UI.WinForms.GunaButton submitButton;
        private Guna.UI.WinForms.GunaTextBox payableAmountTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox discountAmountTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox discountPercentageTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
