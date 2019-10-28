namespace StockManagementSystem
{
    partial class ProductUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reOrderTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.productViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.productViewModelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productViewModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productViewModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ReOrder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(442, 106);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(188, 21);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Model.Category);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(StockManagementSystem.Model.Product);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(442, 143);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(188, 20);
            this.codeTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(442, 182);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // reOrderTextBox
            // 
            this.reOrderTextBox.Location = new System.Drawing.Point(442, 219);
            this.reOrderTextBox.Name = "reOrderTextBox";
            this.reOrderTextBox.Size = new System.Drawing.Size(188, 20);
            this.reOrderTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(442, 254);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(188, 20);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(StockManagementSystem.Model.Product);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(482, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Please Input Product Information";
            // 
            // productViewModelBindingSource
            // 
            this.productViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.ProductViewModel);
            // 
            // productViewModelBindingSource1
            // 
            this.productViewModelBindingSource1.DataSource = typeof(StockManagementSystem.Model.ProductViewModel);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Edit});
            this.showDataGridView.DataSource = this.productViewModelBindingSource4;
            this.showDataGridView.Location = new System.Drawing.Point(148, 374);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(740, 168);
            this.showDataGridView.TabIndex = 13;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick);
            this.showDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellDoubleClick);
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint_1);
            // 
            // productViewModelBindingSource4
            // 
            this.productViewModelBindingSource4.DataSource = typeof(StockManagementSystem.Model.ProductViewModel);
            // 
            // productViewModelBindingSource3
            // 
            this.productViewModelBindingSource3.DataSource = typeof(StockManagementSystem.Model.ProductViewModel);
            // 
            // productViewModelBindingSource2
            // 
            this.productViewModelBindingSource2.DataSource = typeof(StockManagementSystem.Model.ProductViewModel);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Action";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // ProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.reOrderTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductUI";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewModelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox reOrderTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productViewModelBindingSource;
        private System.Windows.Forms.BindingSource productViewModelBindingSource1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.BindingSource productViewModelBindingSource2;
        private System.Windows.Forms.BindingSource productViewModelBindingSource3;
        private System.Windows.Forms.BindingSource productViewModelBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}