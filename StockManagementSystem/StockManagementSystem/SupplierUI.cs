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
    public partial class SupplierUI : Form
    {
        public SupplierUI()
        {
            InitializeComponent();
        }
        StockManager _stockManager = new StockManager();
        Supplier _supplier = new Supplier();

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            //Code
            

            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Can not be Empty!!!");
                return;
            }

            if (codeTextBox.TextLength != 4)
            {
                MessageBox.Show("Code Must be 4 Charecter");
            }
            _supplier.Code = codeTextBox.Text;

            if (_stockManager.IsCodeExists(_supplier))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }



            //Name

            

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            _supplier.Name = nameTextBox.Text;

            //Address

            _supplier.Address = addressTextBox.Text;

            //Email

            

            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Email Can not be Empty!!!");
                return;
            }

            _supplier.Email = emailTextBox.Text;

            if (_stockManager.IsEmailExists(_supplier))
            {
                MessageBox.Show(emailTextBox.Text + "Already Exists!");
                return;
            }

            //Contact

            

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("contact Can not be Empty!!!");
                return;
            }
            if (contactTextBox.TextLength != 11)
            {
                MessageBox.Show("Invalid Phone No!");
            }

            _supplier.Contact = contactTextBox.Text;

            if (_stockManager.IsContactExists(_supplier))
            {
                MessageBox.Show(contactTextBox.Text + "Already Exists!");
                return;
            }

            if (contactPersonTextBox.TextLength != 11)
            {
                MessageBox.Show("Invalid Phone No!");
            }

            //Contact Person

            _supplier.ContactPerson = contactPersonTextBox.Text;

            //bool isAdded = _stockManager.Save(_supplier);

            //if (isAdded)
            //{
            //    MessageBox.Show("Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Not Saved");
            //}

            showDataGridView.DataSource = _stockManager.Display();

            if (saveButton.Text == "Save")
            {
                if (_stockManager.Save(_supplier))
                {
                    MessageBox.Show("Saved!");
                    showDataGridView.DataSource = _stockManager.Display();

                }
                else
                {
                    MessageBox.Show("Not saved!");
                }
            }


            else
            {
                if (_stockManager.Update(_supplier))
                {
                    saveButton.Text = "Save";
                    MessageBox.Show("Updated!");
                    showDataGridView.DataSource = _stockManager.Display();

                }
                else
                {
                    MessageBox.Show("Not Updated!");
                }
            }

            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
            showDataGridView.DataSource = _stockManager.Display();



        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {
            
            showDataGridView.DataSource = _stockManager.Display();


            //DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            //editButton.FlatStyle = FlatStyle.Popup;
            //editButton.HeaderText = "Action";
            //editButton.Name = "Edit";
            //editButton.UseColumnTextForButtonValue = true;
            //editButton.Text = "Edit";
            //editButton.Width = 60;
            //if (showDataGridView.Columns.Contains(editButton.Name = "Edit"))
            //{

            //}
            //else
            //{
            //    showDataGridView.Columns.Add(editButton);
            //}
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1);
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 8 && e.RowIndex!=-1)
            //{
            //    //codeTextBox.Enabled = false;
            //    if(showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //    {
            //        _supplier.ID = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
            //        codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            //        nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //        addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            //        emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //        contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            //        contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();



            //        saveButton.Text = "Update";
            //    }

            //}


            if (showDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                //codeTextBox.Enabled = false;
                if (showDataGridView.CurrentRow != null)
                {
                    showDataGridView.CurrentRow.Selected = true;
                    _supplier.ID = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    saveButton.Text = "Update";
                }
            }
        }
    }
}
