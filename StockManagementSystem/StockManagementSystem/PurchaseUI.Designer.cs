namespace StockManagementSystem
{
    partial class PurchaseUI
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufacturedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.remarksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.previousUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.supplierDateTimePicker);
            this.groupBox1.Controls.Add(this.billTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(201, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(180, 83);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(200, 21);
            this.supplierComboBox.TabIndex = 3;
            this.supplierComboBox.ValueMember = "ID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(StockManagementSystem.Model.Supplier);
            // 
            // supplierDateTimePicker
            // 
            this.supplierDateTimePicker.Location = new System.Drawing.Point(180, 16);
            this.supplierDateTimePicker.Name = "supplierDateTimePicker";
            this.supplierDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.supplierDateTimePicker.TabIndex = 2;
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(180, 48);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(200, 20);
            this.billTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill/Invoice No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.expireDateTimePicker);
            this.groupBox2.Controls.Add(this.manufacturedDateTimePicker);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.remarksRichTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.previousMrpTextBox);
            this.groupBox2.Controls.Add(this.previousUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(35, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.productBindingSource;
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(193, 44);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(195, 21);
            this.productComboBox.TabIndex = 26;
            this.productComboBox.ValueMember = "ID";
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Location = new System.Drawing.Point(191, 168);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expireDateTimePicker.TabIndex = 25;
            // 
            // manufacturedDateTimePicker
            // 
            this.manufacturedDateTimePicker.Location = new System.Drawing.Point(190, 137);
            this.manufacturedDateTimePicker.Name = "manufacturedDateTimePicker";
            this.manufacturedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.manufacturedDateTimePicker.TabIndex = 24;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(191, 16);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(197, 21);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.ValueMember = "ID";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Model.Category);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(460, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Quantity";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(687, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // remarksRichTextBox
            // 
            this.remarksRichTextBox.Location = new System.Drawing.Point(191, 207);
            this.remarksRichTextBox.Name = "remarksRichTextBox";
            this.remarksRichTextBox.Size = new System.Drawing.Size(571, 62);
            this.remarksRichTextBox.TabIndex = 20;
            this.remarksRichTextBox.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Remarks";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(585, 169);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(177, 20);
            this.mrpTextBox.TabIndex = 18;
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Location = new System.Drawing.Point(585, 136);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.ReadOnly = true;
            this.previousMrpTextBox.Size = new System.Drawing.Size(177, 20);
            this.previousMrpTextBox.TabIndex = 16;
            // 
            // previousUnitPriceTextBox
            // 
            this.previousUnitPriceTextBox.Location = new System.Drawing.Point(585, 106);
            this.previousUnitPriceTextBox.Name = "previousUnitPriceTextBox";
            this.previousUnitPriceTextBox.ReadOnly = true;
            this.previousUnitPriceTextBox.Size = new System.Drawing.Size(177, 20);
            this.previousUnitPriceTextBox.TabIndex = 17;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(585, 75);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(177, 20);
            this.totalPriceTextBox.TabIndex = 15;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(585, 43);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(177, 20);
            this.unitPriceTextBox.TabIndex = 13;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(585, 13);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(177, 20);
            this.quantityTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "MRP (Tk)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Previous MRP (Tk)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Previous Unit Price (Tk)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(460, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Price (Tk)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(460, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Unit Price (Tk)";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(191, 106);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.ReadOnly = true;
            this.availableQuantityTextBox.Size = new System.Drawing.Size(197, 20);
            this.availableQuantityTextBox.TabIndex = 5;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(191, 75);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(197, 20);
            this.codeTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Manufactured Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Available Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(StockManagementSystem.Model.Product);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(35, 454);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(829, 60);
            this.showDataGridView.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(722, 521);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // PurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 547);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseUI";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.DateTimePicker supplierDateTimePicker;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.TextBox previousUnitPriceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox remarksRichTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.DateTimePicker manufacturedDateTimePicker;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ComboBox productComboBox;
    }
}