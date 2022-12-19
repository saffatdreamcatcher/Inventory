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
    public class SupplierDLL
    {

        public int Delete(int id)
        {
            int noOfRowAffected = 0;
            var myConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Delete from Supplier where Id = " + id.ToString();
                var obj = comm.ExecuteNonQuery();
                noOfRowAffected = Convert.ToInt32(obj);
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

        public List<Supplier> GetAll(string whereClause = "")
        {
            var suppliers = new List<Supplier>();
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
                comm.CommandText = "Select * from Supplier" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        var supplier = new Supplier(id, createTime);
                        supplier.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        supplier.Address = reader["Address"] is DBNull ? null : reader["Address"].ToString();
                        supplier.Contact = reader["Contact"] is DBNull ? null : reader["Contact"].ToString();
                        supplier.ContactTitle = reader["ContactTitle"] is DBNull ? null : reader["Contacttitle"].ToString();
                        supplier.City = reader["City"] is DBNull ? null : reader["City"].ToString();
                        supplier.PostalCode = reader["PostalCode"] is DBNull ? null : reader["PostalCode"].ToString();
                        supplier.Country = reader["Country"] is DBNull ? null : reader["Country"].ToString();
                        supplier.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                        supplier.Fax = reader["Fax"] is DBNull ? null : reader["Fax"].ToString();
                        supplier.HomePage = reader["HomePage"] is DBNull ? null : reader["HomePage"].ToString();
                        suppliers.Add(supplier);
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
            return suppliers;
        }

        public Supplier GetById(int id)
        {
            var supplier = new Supplier();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Supplier where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        supplier = new Supplier(id, createTime);
                        supplier.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        supplier.Address = reader["Address"] is DBNull ? null : reader["Address"].ToString();
                        supplier.Contact = reader["Contact"] is DBNull ? null : reader["Contact"].ToString();
                        supplier.ContactTitle = reader["ContactTitle"] is DBNull ? null : reader["ContactTitle"].ToString();
                        supplier.City = reader["City"] is DBNull ? null : reader["City"].ToString();
                        supplier.PostalCode = reader["PostalCode"] is DBNull ? null : reader["PostalCode"].ToString();
                        supplier.Country = reader["Country"] is DBNull ? null : reader["Country"].ToString();
                        supplier.Region = reader["region"] is DBNull ? null : reader["Region"].ToString();
                        supplier.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                        supplier.Fax = reader["Fax"] is DBNull ? null : reader["Fax"].ToString();
                        supplier.HomePage = reader["HomePage"] is DBNull ? null : reader["HomePage"].ToString();

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
            return supplier;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var supplierr = new Supplier();
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
                comm.CommandText = "Select count(*) from Supplier " + whereClause;
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

        public int Save(Supplier supplier)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (supplier.IsNew)
                {
                    comm.CommandText = "INSERT INTO Supplier(CreateTime, Name, Contact, ContactTitle, Address, City, PostalCode, Country, Phone, Fax, HomePage) VALUES (@CreateTime, @Name, @Contact, @ContactTitle, @Address, @City, @PostalCode, @Country, @Phone, @Fax, @HomePage); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Supplier SET Name = @Name, Contact = @Contact, ContactTitle = @ContactTitle, Address = @Address, City = @City, PostalCode= @PostalCode, Country= @Country, Phone = @Phone, Fax = @Fax, HomePage = @HomePage  WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = supplier.Id;
                }
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = supplier.Name;
                comm.Parameters.Add("@Contact", SqlDbType.VarChar).Value = supplier.Contact;
                comm.Parameters.Add("@ContactTitle", SqlDbType.VarChar).Value = supplier.ContactTitle;
                comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = supplier.Address;
                comm.Parameters.Add("@Country", SqlDbType.VarChar).Value = supplier.Country;
                comm.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = supplier.PostalCode;
                comm.Parameters.Add("@City", SqlDbType.VarChar).Value = supplier.City;
                comm.Parameters.Add("@Phone", SqlDbType.VarChar).Value = supplier.Phone;
                comm.Parameters.Add("@Fax", SqlDbType.VarChar).Value = supplier.Fax;
                comm.Parameters.Add("@HomePage", SqlDbType.VarChar).Value = supplier.HomePage;
                if (supplier.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    supplier.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = supplier.Id;
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
