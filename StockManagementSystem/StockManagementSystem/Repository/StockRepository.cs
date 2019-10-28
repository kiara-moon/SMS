using StockManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Repository
{
    class StockRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        Product product = new Product();

        public bool GetSave(Product product)
        {
            bool isAdded = false;
            try 
            {
                //Connection
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"INSERT INTO Products Values ('" + product.Code + "', '" + product.Name + "', " + product.ReorderLevel + ",' " + product.ProductDescription + "', " + product.ID + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }

        public bool IsCodeExists(Product product)
        {
            bool exists = false;
            try
            {
                //Connection
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT Code FROM Products WHERE Code = " + product.Code+" AND ID !="+product.ID+" ";
          
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool IsNameExists(Product product)
        {
            bool exists = false;
            try
            {
                //Connection

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //string commandString = @"SELECT Code,Name FROM Items WHERE Name='" + item.Name + "'";
                string commandString = @"SELECT Name FROM Products Where Name = '" + product.Name + "' AND ID !=" + product.ID + " ";

                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return exists;
        }

        public bool Update(Product product)
        {
            try
            {
                //Connection
               SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Products SET Code = '" + product.Code + "',Name= '" + product.Name + "',ReorderLevel= '" + product.ReorderLevel + "',ProductDescription= ' " + product.ProductDescription + "',CateogoryID= '" + product.ID + "' WHERE ID = " + product.ID + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return false;
        }
        
        public DataTable GetProductDisplay()
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //@"SELECT * FROM ProductDetailsView"; 
                string commandString = @"SELECT * FROM ProductDetailsView";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
               
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }

    }
}
