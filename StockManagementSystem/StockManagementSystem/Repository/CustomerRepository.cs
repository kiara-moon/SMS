using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using System.Data;
using System.Data.SqlClient;
using StockManagementSystem.BLL;
using System.Configuration;

namespace StockManagementSystem.Repository
{
    public class CustomerRepository
    {

        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public bool AddCustomer(Customer _customer)
        {
            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"INSERT INTO Customers (Code, Name,  Address, Email,Contact,LoyaltyPoint) VALUES('" + _customer.Code + "', '" + _customer.Name + "', '" + _customer.Address + "', '" + _customer.Email + "', '" + _customer.Contact + "', " + _customer.LoyaltyPoint + ")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isAdded = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (isAdded > 0)
                return true;
            else
                return false;
        }
        

        public bool UpdateCustomer(Customer _customer)
        {
            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"UPDATE Customers SET Code = '" + _customer.Code + "', Name = '" + _customer.Name + "', Address = '" + _customer.Address + "',  Email = '" + _customer.Email + "',Contact = '" + _customer.Contact + "' , LoyaltyPoint = " + _customer.LoyaltyPoint + "  WHERE ID = " + _customer.ID + " ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isUpdated = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (isUpdated > 0)
                return true;
            else
                return false;
        }
        public List<ViewCustomer> Display()
        {
            List<ViewCustomer> viewCustomers = new List<ViewCustomer>();

            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                

                ViewCustomer viewCustomer = new ViewCustomer();

                viewCustomer.ID = Convert.ToInt32(sqlDataReader["ID"]);
                viewCustomer.Code = sqlDataReader["Code"].ToString();
                viewCustomer.Name = sqlDataReader["Name"].ToString();
                viewCustomer.Address = sqlDataReader["Address"].ToString();
                viewCustomer.Email = sqlDataReader["Email"].ToString();               
                viewCustomer.Contact = sqlDataReader["Contact"].ToString();
                viewCustomer.LoyaltyPoint = Convert.ToDouble(sqlDataReader["LoyaltyPoint"].ToString());

                viewCustomers.Add(viewCustomer);
            }

            sqlConnection.Close();

            return viewCustomers;
        }

        public bool IsCodeUniqe(Customer customer)
        {
            string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT Code FROM Customers WHERE Code = '" +customer.Code + "' AND ID !=" +customer.ID +"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            int flag = 0;
            while (sqlDataReader.Read())
            {
                flag = 1;
                break;
            }

            sqlConnection.Close();

            if (flag == 0)
                return true;
            else
                return false;
        }

        public bool IsContactUniqe(string contact )
        {
           string sqlString = @"Server=DESKTOP-LO8RRRJ; Database=SMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Customers WHERE Contact = '" + contact + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            int flag = 0;
            while (sqlDataReader.Read())
            {
                flag = 1;
                break;
            }

            sqlConnection.Close();

            if (flag == 0)
                return true;
            else
                return false;
        }

    }
}
