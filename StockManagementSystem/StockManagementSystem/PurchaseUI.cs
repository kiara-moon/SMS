using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Model;


namespace StockManagementSystem
{
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
        }

        PurchaseManager _purchaseManager = new PurchaseManager();
        Purchase purchase = new Purchase();
        Product product = new Product();


        

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _purchaseManager.GetAllCategory();
            supplierComboBox.DataSource = _purchaseManager.GetSupplierComboBox();
            productComboBox.DataSource = _purchaseManager.ShowProduct();
            codeTextBox.Text = "";
            //productComboBox.Enabled = false;
            
           

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex > -1)
            {
                
                purchase.CateogoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
                productComboBox.DataSource = _purchaseManager.GetProduct(purchase);
                

            }



            



        }




        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (productComboBox.SelectedIndex>-1)
            //{
            //    purchase.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
            //    codeTextBox.Text = _purchaseManager.GetProductCode(purchase);
            //}
            
           if (productComboBox.SelectedValue!=null)
            { 
              codeTextBox.Text = _purchaseManager.GetProductCode(Convert.ToInt32(productComboBox.SelectedValue)).ToString();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



    }
}
