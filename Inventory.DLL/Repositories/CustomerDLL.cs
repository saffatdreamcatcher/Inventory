using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Repositories
{
    public class CustomerDLL
    {
        public int Delete(int id)
        {
            int noOfRowAffected = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Delete from Customer where Id = " + id.ToString();
                noOfRowAffected = comm.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return noOfRowAffected;

        }

        public List<Customer> GetAll(string whereClause = "")
        {
            var customers = new List<Customer>();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Customer" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        var customer = new Customer(id, createTime);
                        customer.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        customer.Address = reader["Address"] is DBNull ? null : reader["Address"].ToString();
                        customer.Contact = reader["Contact"] is DBNull ? null : reader["Contact"].ToString();
                        customer.City = reader["City"] is DBNull ? null : reader["City"].ToString();
                        customer.PostalCode = reader["PostalCode"] is DBNull ? null : reader["PostalCode"].ToString();
                        customer.Country = reader["Country"] is DBNull ? null : reader["Country"].ToString();
                        customers.Add(customer);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }

        public Customer GetById(int id)
        {
            var customer = new Customer();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Customer where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        customer = new Customer(id, createTime);
                        customer.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        customer.Address = reader["Address"] is DBNull ? null : reader["Address"].ToString();
                        customer.Contact = reader["Contact"] is DBNull ? null : reader["Contact"].ToString();
                        customer.City = reader["City"] is DBNull ? null : reader["City"].ToString();
                        customer.PostalCode = reader["PostalCode"] is DBNull ? null : reader["PostalCode"].ToString();
                        customer.Country = reader["Country"] is DBNull ? null : reader["Country"].ToString();

                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return customer;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var customer = new Customer();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select count(*) from Customer " + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public int Save(Customer customer)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (customer.IsNew)
                {
                    comm.CommandText = "INSERT INTO Customer(CreateTime, Name, Contact, Address, City, PostalCode, Country) VALUES(@CreateTime, @Name, @Contact, @Address, @City, @PostalCode, @Country); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Customer SET Name = @Name, Contact = @Contact, Address = @Address, City = @City, PostalCode= @PostalCode, Country= @Country WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = customer.Id;
                }
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = customer.Name;
                comm.Parameters.Add("@Contact", SqlDbType.VarChar).Value = customer.Contact;
                comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = customer.Address;
                comm.Parameters.Add("@Country", SqlDbType.VarChar).Value = customer.Country;
                comm.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = customer.PostalCode;
                comm.Parameters.Add("@City", SqlDbType.VarChar).Value = customer.City;
                if (customer.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    customer.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = customer.Id;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return primaryKey;
        }
    }

}  
