using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StockManagementSystem.Model;
using System.Configuration;
using System.Windows.Forms;

namespace StockManagementSystem.Repository
{
    class SupplierRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        Supplier supplier = new Supplier();

        public bool Save(Supplier supplier)
        {
            bool isAdded = false;
            try
            {
                //Connection
                // Data Source = DESKTOP - SSEF4DE; Initial Catalog = SMS; Integrated Security = True
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Suppliers Values ('" + supplier.Code + "', '" + supplier.Name + "', '" + supplier.Address + "','" + supplier.Email + "', '" + supplier.Contact+ "','" + supplier.ContactPerson + "')";
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
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        
        }

        public bool IsCodeExists(Supplier supplier)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT Code FROM Suppliers WHERE Code=" + supplier.Code + " AND ID !=" + supplier.ID + "";
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
            catch (Exception exception)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }

        public bool IsContactExists(Supplier supplier)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT Contact FROM Suppliers WHERE Contact='" + supplier.Contact + "' AND ID !=" + supplier.ID + "";
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return exists;
        }



        public bool IsEmailExists(Supplier supplier)

        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"SELECT Email FROM Suppliers WHERE Email='" + supplier.Email + "' AND ID !=" + supplier.ID + "";
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message); 
            }

            return exists;
        }

        public bool Update(Supplier supplier)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Suppliers SET Code = '" + supplier.Code + "',Name= '" + supplier.Name + "',Address= '" + supplier.Address + "',Email= ' " + supplier.Email+ "',Contact= '" + supplier.Contact + "',ContactPerson= '" + supplier.ContactPerson+ "' WHERE ID = " + supplier.ID + " ";
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
                //MessageBox.Show(exeption.Message);
            }
            return false;
        }

        public DataTable Display()
        {

            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Suppliers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;
            
        }


        public DataTable GetSupplierFromComboBox()
        {

            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Suppliers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;




        }



        //public List<Supplier> GetSupplierFromComboBox()
        //{
        //    List<Supplier> suppliers = new List<Supplier>();
        //    string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(sqlString);

        //    string commandString = @"SELECT * FROM Suppliers";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


        //    Supplier supplier1 = new Supplier
        //    {
        //        ID = 1,
        //        Name = "--Select--"
        //    };
        //    suppliers.Add(supplier);
        //    while (sqlDataReader.Read())
        //    {
        //        Supplier supplier = new Supplier ();
        //        supplier.ID = Convert.ToInt32(sqlDataReader["ID"]);
        //        supplier.Code = sqlDataReader["Code"].ToString();
        //        supplier.Name = sqlDataReader["Name"].ToString();

        //        suppliers.Add(supplier);
        //    }
        //    return suppliers;
        //}





    }
}
