namespace StockManagement.Design
{
    partial class OrderProductUserControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productErrorabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new Guna.UI.WinForms.GunaButton();
            this.totalPriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.quantityTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.remarksTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.lastCPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.supplierComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.supplierErrorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitButton = new Guna.UI.WinForms.GunaButton();
            this.showDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deliveryDatePicker);
            this.groupBox2.Controls.Add(this.orderDatePicker);
            this.groupBox2.Controls.Add(this.gunaTextBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.gunaTextBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.gunaTextBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.categoryErrorLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productErrorabel);
            this.groupBox2.Location = new System.Drawing.Point(77, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDatePicker.Location = new System.Drawing.Point(473, 141);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(175, 25);
            this.deliveryDatePicker.TabIndex = 5;
            this.deliveryDatePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // orderDatePicker
            // 
            this.orderDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDatePicker.Location = new System.Drawing.Point(119, 140);
            this.orderDatePicker.Name = "orderDatePicker";
            this.orderDatePicker.Size = new System.Drawing.Size(175, 25);
            this.orderDatePicker.TabIndex = 5;
            this.orderDatePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.BorderSize = 1;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.Location = new System.Drawing.Point(473, 100);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(175, 26);
            this.gunaTextBox4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Status";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.BorderSize = 1;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(473, 59);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Size = new System.Drawing.Size(175, 26);
            this.gunaTextBox3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Re-order Level";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.BorderSize = 1;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(473, 19);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(175, 26);
            this.gunaTextBox2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Available Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Date";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BaseColor = System.Drawing.Color.White;
            this.codeTextBox.BorderColor = System.Drawing.Color.Silver;
            this.codeTextBox.BorderSize = 1;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.codeTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.codeTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.codeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTextBox.Location = new System.Drawing.Point(118, 99);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.Size = new System.Drawing.Size(175, 26);
            this.codeTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code";
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
            this.categoryComboBox.Location = new System.Drawing.Point(118, 19);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.categoryComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.categoryComboBox.Size = new System.Drawing.Size(175, 26);
            this.categoryComboBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 25);
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
            this.productComboBox.Location = new System.Drawing.Point(118, 59);
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
            this.categoryErrorLabel.Location = new System.Drawing.Point(116, 44);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(117, 13);
            this.categoryErrorLabel.TabIndex = 1;
            this.categoryErrorLabel.Text = "Please Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // productErrorabel
            // 
            this.productErrorabel.AutoSize = true;
            this.productErrorabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorabel.ForeColor = System.Drawing.Color.Red;
            this.productErrorabel.Location = new System.Drawing.Point(116, 84);
            this.productErrorabel.Name = "productErrorabel";
            this.productErrorabel.Size = new System.Drawing.Size(112, 13);
            this.productErrorabel.TabIndex = 1;
            this.productErrorabel.Text = "Please Select Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.totalPriceTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.remarksTextBox);
            this.groupBox1.Controls.Add(this.lastCPTextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.supplierErrorLabel);
            this.groupBox1.Location = new System.Drawing.Point(77, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
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
            this.addButton.Location = new System.Drawing.Point(523, 132);
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
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.BaseColor = System.Drawing.Color.White;
            this.totalPriceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.totalPriceTextBox.BorderSize = 1;
            this.totalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.totalPriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.totalPriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalPriceTextBox.Location = new System.Drawing.Point(473, 54);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.PasswordChar = '\0';
            this.totalPriceTextBox.Size = new System.Drawing.Size(175, 26);
            this.totalPriceTextBox.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Price";
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
            this.quantityTextBox.Location = new System.Drawing.Point(473, 14);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.Size = new System.Drawing.Size(175, 26);
            this.quantityTextBox.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Remarks";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.BaseColor = System.Drawing.Color.White;
            this.remarksTextBox.BorderColor = System.Drawing.Color.Silver;
            this.remarksTextBox.BorderSize = 1;
            this.remarksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remarksTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.remarksTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.remarksTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.remarksTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remarksTextBox.Location = new System.Drawing.Point(120, 85);
            this.remarksTextBox.MultiLine = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.PasswordChar = '\0';
            this.remarksTextBox.Size = new System.Drawing.Size(528, 43);
            this.remarksTextBox.TabIndex = 0;
            // 
            // lastCPTextBox
            // 
            this.lastCPTextBox.BaseColor = System.Drawing.Color.White;
            this.lastCPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.lastCPTextBox.BorderSize = 1;
            this.lastCPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastCPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.lastCPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.lastCPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.lastCPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastCPTextBox.Location = new System.Drawing.Point(119, 55);
            this.lastCPTextBox.Name = "lastCPTextBox";
            this.lastCPTextBox.PasswordChar = '\0';
            this.lastCPTextBox.Size = new System.Drawing.Size(175, 26);
            this.lastCPTextBox.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Last CP (Tk.)";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.BackColor = System.Drawing.Color.Transparent;
            this.supplierComboBox.BaseColor = System.Drawing.Color.White;
            this.supplierComboBox.BorderColor = System.Drawing.Color.Silver;
            this.supplierComboBox.BorderSize = 1;
            this.supplierComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.supplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.supplierComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.supplierComboBox.ForeColor = System.Drawing.Color.Black;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(119, 14);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.supplierComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.supplierComboBox.Size = new System.Drawing.Size(175, 26);
            this.supplierComboBox.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Supplier";
            // 
            // supplierErrorLabel
            // 
            this.supplierErrorLabel.AutoSize = true;
            this.supplierErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierErrorLabel.Location = new System.Drawing.Point(117, 39);
            this.supplierErrorLabel.Name = "supplierErrorLabel";
            this.supplierErrorLabel.Size = new System.Drawing.Size(117, 13);
            this.supplierErrorLabel.TabIndex = 1;
            this.supplierErrorLabel.Text = "Please Select Category";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.showDataGridView);
            this.panel1.Location = new System.Drawing.Point(77, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 190);
            this.panel1.TabIndex = 3;
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
            this.submitButton.Location = new System.Drawing.Point(521, 149);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.submitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.submitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.submitButton.OnHoverImage = null;
            this.submitButton.OnPressedColor = System.Drawing.Color.Black;
            this.submitButton.Radius = 15;
            this.submitButton.Size = new System.Drawing.Size(125, 34);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit Order";
            this.submitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.showDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.showDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.showDataGridView.Location = new System.Drawing.Point(2, 0);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.RowHeadersVisible = false;
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(695, 147);
            this.showDataGridView.TabIndex = 0;
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
            // OrderProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrderProductUserControl";
            this.Size = new System.Drawing.Size(881, 570);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox categoryComboBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox productComboBox;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label productErrorabel;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.DateTimePicker orderDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton addButton;
        private Guna.UI.WinForms.GunaTextBox totalPriceTextBox;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaTextBox quantityTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaTextBox remarksTextBox;
        private Guna.UI.WinForms.GunaTextBox lastCPTextBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaComboBox supplierComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label supplierErrorLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView showDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewImageColumn Action;
        private Guna.UI.WinForms.GunaButton submitButton;
    }
}
