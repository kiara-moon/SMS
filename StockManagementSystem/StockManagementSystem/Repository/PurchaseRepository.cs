using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    class PurchaseRepository
    {
        public DataTable ShowProduct()
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command 
                //@"SELECT * FROM ProductDetailsView"; 
                string commandString = @"SELECT * FROM Products";
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
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }






        public DataTable GetProduct(Purchase purchase)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Command 
                //@"SELECT * FROM ProductDetailsView"; 
                string commandString = @"SELECT p.Name From Products as p LEFT JOIN Categories as c on c.ID=p.CateogoryID WHERE p.CateogoryID=" + purchase.CateogoryID + "";
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
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }

        //public DataTable GetCategory(Purchase purchase)
        //{
        //    DataTable dataTable = new DataTable();
        //    try
        //    {
        //        //Connection
        //        string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //        SqlConnection sqlConnection = new SqlConnection(connectionString);
        //        //Command 
        //        //@"SELECT * FROM ProductDetailsView"; 
        //        string commandString = @"SELECT c.Name From Products as p LEFT JOIN Categories as c on c.ID=p.CateogoryID WHERE p.ID=" + purchase.ProductID + "";
        //        SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //        //Open
        //        sqlConnection.Open();

        //        //Show
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //        sqlDataAdapter.Fill(dataTable);

        //        //Close
        //        sqlConnection.Close();

        //    }
        //    catch (Exception exeption)
        //    {
        //        //MessageBox.Show(exeption.Message);
        //    }
        //    return dataTable;
        //}


        //public double GetPreviousMRP(Product product)
        //{
        //    //Connection
        //    string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    //Command 
        //    //@"SELECT * FROM ProductDetailsView"; 
        //    string commandString = @"SELECT MRP From Purchases WHERE ProductID = " + product.ID + " ORDER BY ProductID DESC";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //Open
        //    sqlConnection.Open();

        //    SqlDataReader dr = sqlCommand.ExecuteReader();
        //    double MRP=0;
        //    while (dr.Read())
        //    {


        //        MRP = (Convert.ToDouble(dr["MRP"]));
        //    }


        //    //Show
        //    //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //    //sqlDataAdapter.Fill(dataTable);

        //    //Close
        //    sqlConnection.Close();

        //    return MRP;
        //}

        //public double GetPreviousUnitPrice(Product product)
        //{
        //    //Connection
        //    string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    //Command 
        //    //@"SELECT * FROM ProductDetailsView"; 
        //    string commandString = @"SELECT UnitPrice From Purchases WHERE ProductID = " + product.ID + " ORDER BY ProductID DESC";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //Open
        //    sqlConnection.Open();

        //    SqlDataReader dr = sqlCommand.ExecuteReader();
        //    double unitPrice=0;
        //    while (dr.Read())
        //    {


        //        unitPrice = (Convert.ToDouble(dr["UnitPrice"]));
        //    }


        //    //Show
        //    //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //    //sqlDataAdapter.Fill(dataTable);

        //    //Close
        //    sqlConnection.Close();

        //    return unitPrice;
        //}

        public string GetProductCode(int productId)
        {



            //Connection
            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //@"SELECT * FROM ProductDetailsView"; 
            string commandString = @"SELECT * From Products WHERE ID = " + productId + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader dr = sqlCommand.ExecuteReader();
            string productCode = "";
            while (dr.Read())
            {


                productCode = (string)dr["ProductDescription"].ToString();
            }


            //Show
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //sqlDataAdapter.Fill(dataTable);

            //Close
            sqlConnection.Close();

            return productCode;


        }

        //public int GetAvailableQuantity(Purchase purchase, Sales sales)
        //{

        //}


    }
}
