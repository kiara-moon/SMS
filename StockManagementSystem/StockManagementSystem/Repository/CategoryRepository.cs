
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using System.Data.SqlClient;
using System.Data;

namespace StockManagementSystem.Repository
{
    class CategoryRepository
    {
        
        public List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //string queryString = @"SELECT * FROM Categories";
            //SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlString);

            string commandString = @"SELECT * FROM Categories";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Category category1 = new Category
            {
                ID = 1,
                Name = "--Select--"
            };
            categories.Add(category1);
            while (sqlDataReader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            return categories;
        
        }


        public List<Product> GetProductFromComboBox()
        {
            List<Product> products = new List<Product>();
            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlString);

            string commandString = @"SELECT * FROM Products";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);



            sqlConnection.Open();




            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            Product product1 = new Product
            {
                ID = 1,
                Name = "--Select--"
            };
            products.Add(product1);
            while (sqlDataReader.Read())
            {
                Product product = new Product();
                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                product.ProductDescription = sqlDataReader["ProductDescription"].ToString();
                product.CategoryID = Convert.ToInt32(sqlDataReader["CateogoryID"]);
            


                products.Add(product);
            }
            return products;
        }



        //public bool ViewQuantity(string productCombo,int quantity, int prevMRP, int prevUnitPrice)
        //{
            
        //    string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(sqlString);

        //    string commandString = @"SELECT * FROM Products Where Name='"+productCombo+"'";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);



        //    sqlConnection.Open();




        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    while (sqlDataReader.Read())
        //    {
        //        quantity = (int)sqlDataReader["Quantity"];
        //        prevMRP = (int)sqlDataReader["PrevMRP"];
        //        prevUnitPrice = (int)sqlDataReader["PrevUnitPrice"];
        //    }

        //    sqlConnection.Close();

        //    return true;


        //}

        //public void GetProductFromComboBox(int ID)
        //{

        //    string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(sqlString);

        //    string commandString = @"SELECT * FROM Products Where CategoryID=@ID";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();
           
        //    sqlCommand.Parameters.AddWithValue("CategoryID", ID);
        //    SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    sqlConnection.Close();
            
        //    dt.NewRow().ItemArray = new object[] { 0, "--Select Product--" };
        //    dt.Rows.InsertAt(dt.NewRow(), 0);

            

            





        //}



    }

}
