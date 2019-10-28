using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StockManagementSystem.Model;
using StockManagementSystem.BLL;

namespace StockManagementSystem.Repository
{
    class NewPurchaseRepository
    {
        public List<Supplier> SupplierComboItem()
        {
            List<Supplier> suppliers = new List<Supplier>();

            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT ID, Name FROM Suppliers";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();

                supplier.ID = Convert.ToInt32(sqlDataReader["ID"]);
                supplier.Name = sqlDataReader["Name"].ToString();

                suppliers.Add(supplier);
            }

            Supplier s = new Supplier();
            s.ID = 0;
            s.Name = "-SELECT-";
            suppliers.Insert(0, s);

            sqlConnection.Close();

            return suppliers;
        }

        public List<Category> CategoryComboItem()
        {
            List<Category> categories = new List<Category>();
            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT ID, Name FROM Categories";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();

                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }

            Category cat = new Category();
            cat.ID = 0;
            cat.Name = "-SELECT-";

            categories.Insert(0, cat);

            sqlConnection.Close();

            return categories;
        }


        public List<Product> GetProductFromCategory(int categoryId)
        {
            List<Product> products = new List<Product>();
            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Products WHERE CateogoryID = " + categoryId + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.CategoryID = Convert.ToInt32(sqlDataReader["CateogoryID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                product.ProductDescription = sqlDataReader["ProductDescription"].ToString();

                products.Add(product);
            }

            Product p = new Product();
            p.ID = 0;
            p.Name = "-SELECT-";
            products.Insert(0, p);

            sqlConnection.Close();

            return products;
        }

        public Product SearchProductById(int id)
        {
            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM Products WHERE ID = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Product product = new Product();
            while (sqlDataReader.Read())
            {


                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.CategoryID = Convert.ToInt32(sqlDataReader["CateogoryID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                product.ProductDescription = sqlDataReader["ProductDescription"].ToString();
            }

            return product;
        }

        public NewPurchase LastPurchaseInfo(int productId)
        {
            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT UnitPrice, MRP FROM NewPurchases WHERE ID IN(SELECT max(ID) FROM NewPurchases WHERE ProductID = " + productId + ")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            NewPurchase newPurchase = new NewPurchase();
            while (sqlDataReader.Read())
            {
                newPurchase = new NewPurchase();

                //purchase.ID = Convert.ToInt32(sqlDataReader["ID"]);
                newPurchase.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"]); 
                newPurchase.MRP = Convert.ToDouble(sqlDataReader["MRP"]);

            }

            sqlConnection.Close();

            return newPurchase;
        }

        public int AvailableQuantity(int productId)
        {
            string commandString = @"Select * FROM AvailableQuantity WHERE ProductID = " + productId + "";

            string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Purchase purchase = new Purchase();
            int quantity = 0;
            while (sqlDataReader.Read())
            {
                quantity = Convert.ToInt32(sqlDataReader["PurchaseQuantity"]);
            }

            sqlConnection.Close();

            return quantity;
        }


        public bool AddPurchase(NewPurchase newPurchase)
        {
            
            bool isAdded = false;
            try
            {
                string commandString;
                if (newPurchase.ManuDate == null && newPurchase.ExpiredDate == null)
                    commandString = @"INSERT INTO NewPurchases (Date, BillNo, SupplierID, ProductID, PurchaseQuantity, UnitPrice, MRP) VALUES('" + newPurchase.Date + "','" + newPurchase.BillNo + "'," + newPurchase.SupplierID + "," + newPurchase.ProductID + ", " + newPurchase.PurchaseQuantity + "," + newPurchase.UnitPrice + "," + newPurchase.MRP + ")";
                else
                    commandString = @"INSERT INTO NewPurchases (Date, BillNo, SupplierID, ProductID, ManuDate, ExpiredDate, PurchaseQuantity, UnitPrice, MRP) VALUES('" + newPurchase.Date + "','" + newPurchase.BillNo + "'," + newPurchase.SupplierID + "," + newPurchase.ProductID + ",'" + newPurchase.ManuDate + "','" + newPurchase.ExpiredDate + "', " + newPurchase.PurchaseQuantity + "," + newPurchase.UnitPrice + "," + newPurchase.MRP + ")";

                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();
            }
            catch(Exception exception)
            {
                //MessageBox.Show(exeption.Message);
                
            }

            return isAdded;
        }
    }
}
