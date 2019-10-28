using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Model;
using StockManagementSystem.BLL;

namespace StockManagementSystem
{
    public partial class NewPurchaseUI : Form
    {
        public NewPurchaseUI()
        {
            InitializeComponent();
        }

        NewPurchaseManager _newPurchaseManager = new NewPurchaseManager();
        StockManager _stockManager = new StockManager();
        List<NewPurchase> _purchaseList = new List<NewPurchase>();

        Product product = new Product();

        
        private void NewPurchaseUI_Load(object sender, EventArgs e)
        {
            supplierComboBox.DataSource = _newPurchaseManager.SupplierComboItem();

            categoryComboBox.DataSource = _newPurchaseManager.CategoryComboItem();

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!IsValid())
                //    return;

                NewPurchase newPurchase = new NewPurchase();

                if (manufacturedDateTimePicker.Text == "--/--/----")
                    newPurchase.ManuDate = null;
                else
                    newPurchase.ManuDate = Convert.ToString(manufacturedDateTimePicker.Text);

                if (expireDateTimePicker.Text == "--/--/----")
                    newPurchase.ExpiredDate = null;
                else
                    newPurchase.ExpiredDate = Convert.ToString(expireDateTimePicker.Text);

                newPurchase.Date = Convert.ToString(supplierDateTimePicker.Text);
                newPurchase.BillNo = billTextBox.Text;
                newPurchase.SupplierID = Convert.ToInt32(supplierComboBox.SelectedValue);
                newPurchase.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
                newPurchase.PurchaseQuantity = Convert.ToInt32(quantityTextBox.Text);
                newPurchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                newPurchase.MRP = Convert.ToDouble(mrpTextBox.Text);

                _purchaseList.Add(newPurchase);

                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _purchaseList;

                Reset();

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Reset()
        {
            categoryComboBox.SelectedValue = 0;
            manufacturedDateTimePicker.CustomFormat = "--/--/----";
            expireDateTimePicker.CustomFormat = "--/--/----";
            codeTextBox.ResetText();
            quantityTextBox.ResetText();
            unitPriceTextBox.ResetText();
            totalPriceTextBox.ResetText();
            mrpTextBox.ResetText();
            remarksRichTextBox.ResetText();
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
                    if (_newPurchaseManager.AddPurchase(_purchaseList))
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

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource = _newPurchaseManager.GetProductFromCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(productComboBox.SelectedValue) > 0)
            {
                product = _newPurchaseManager.SearchProductById(Convert.ToInt32(productComboBox.SelectedValue));
                NewPurchase newPurchase = _newPurchaseManager.LastPurchaseInfo(Convert.ToInt32(productComboBox.SelectedValue));
                int quantity = _newPurchaseManager.AvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue));

                codeTextBox.Text = product.Code; 
                previousUnitPriceTextBox.Text = newPurchase.UnitPrice.ToString();
                previousMrpTextBox.Text = newPurchase.MRP.ToString();
                availableQuantityTextBox.Text = quantity.ToString();
            }
        }


        private void unitPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
                mrpTextBox.Text = (Convert.ToDouble(unitPriceTextBox.Text) + (Convert.ToDouble(unitPriceTextBox.Text) * 25) / 100).ToString();
            }
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1);
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NewPurchase newPurchase = new NewPurchase();
            if (showDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                //codeTextBox.Enabled = false;
                if (showDataGridView.CurrentRow != null)
                {
                    //showDataGridView.CurrentRow.Selected = true;
                    //newPurchase.ID = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    //codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    //saveButton.Text = "Update"; 
                }
            }
        }
    }
}
