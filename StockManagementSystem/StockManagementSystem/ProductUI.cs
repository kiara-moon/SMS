using StockManagementSystem.BLL;
using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class ProductUI : Form
       
    {
        //object call
        //CategoryManager _categoryManager = new CategoryManager();
        StockManager _stockManager = new StockManager();
        Product _product = new Product();

        public ProductUI()
        {
            InitializeComponent();
        }
        
        private void SaveButton(object sender, EventArgs e)
        {
            //Input field
            //Set Price as Mandatory
            _product.ID = Convert.ToInt32(categoryComboBox.SelectedValue);
            if (String.IsNullOrEmpty(categoryComboBox.Text))
            {
                MessageBox.Show("Must be Select Can not be Empty!!!");
                return;
            }
            
            _product.Code = codeTextBox.Text;
            //Set Code as Mandatory
            if (String.IsNullOrEmpty(_product.Code))
            {
                MessageBox.Show("Code Can not be Empty!!!");
                return;
            }
            //Code Lenth 4
            if (_product.Code.Length != 4)
            {
                MessageBox.Show("Please 4 disig requeired");
                return;
            }
            //Check UNIQUE
            if (_stockManager.IsCodeExists(_product))
            {
                MessageBox.Show(codeTextBox.Text+"Code already Exist !");
                return;
            }

            _product.Name = nameTextBox.Text;
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(_product.Name))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }
            //Check UNIQUE
            if (_stockManager.IsNameExists(_product))
            {
                MessageBox.Show(nameTextBox.Text + "Name already Exist !");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(reOrderTextBox.Text))
            {
                MessageBox.Show("ReOrder Leve Can not be Empty!!!");
                return;
            }
            _product.ReorderLevel = Convert.ToInt32(reOrderTextBox.Text);

            _product.ProductDescription = descriptionTextBox.Text;
            //call Method and show gridview
            //showDataGridView.DataSource = _stockManager.GetSave(_product);
            showDataGridView.DataSource = _stockManager.Display();


            //Update information Afsar
            if (saveButton.Text == "Save")
            {

                if (_stockManager.GetSave(_product))
                {
                    MessageBox.Show("Data Saved Successfully..!!");
                    showDataGridView.DataSource = _stockManager.GetProductDisplay();
                }
                else
                {
                    MessageBox.Show("Not Saved..!!");
                }
            }
            else 
            {
                if (_stockManager.Update(_product))
                {
                    MessageBox.Show("Data Update Successfully..!!");
                    showDataGridView.DataSource = _stockManager.GetProductDisplay();
                }
                else
                {
                    MessageBox.Show("Not Update..!!");
                }
            }

            //clear field
            nameTextBox.Clear();
            codeTextBox.Clear();
            reOrderTextBox.Clear();
            descriptionTextBox.Clear();

        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            //ComboBox field DropdownStyle
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Method call, category field data call from category table 
            //categoryComboBox.DataSource = _categoryManager.GetAllCategory();
            //display data to gridview
            showDataGridView.DataSource = _stockManager.GetProductDisplay();

        }

        private void showDataGridView_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //serial number set
            this.showDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1);
        }

        private void showDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
         private void ClearAllErrorLabel()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }
        private void ClearAllInputField()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            reOrderTextBox.Clear();
            categoryComboBox.SelectedIndex = 0;
            descriptionTextBox.Clear();
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(showDataGridView.Columns[e.ColumnIndex].Name=="Edit")
            {
                //codeTextBox.Enabled = false;
                if (showDataGridView.CurrentRow != null)
                {
                    showDataGridView.CurrentRow.Selected = true;
                    _product.ID = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    categoryComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    reOrderTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    descriptionTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    saveButton.Text = "Update";
                    MessageBox.Show(""+_product.ID);

                }
            }
            

        }
    }
}
