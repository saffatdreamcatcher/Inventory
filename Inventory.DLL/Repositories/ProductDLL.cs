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
  public class ProductDLL
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
        comm.CommandText = "Delete from Product where Id = " + id.ToString();
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

    public List<Product> GetAll(string whereClause = "")
    {
      var products = new List<Product>();
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
        comm.CommandText = "Select * from Product" + whereClause;
        using (SqlDataReader reader = comm.ExecuteReader())
        {
          while (reader != null && reader.Read())
          {
            int id = Convert.ToInt32(reader["id"]);
            DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
            var product = new Product(id, createTime);
            product.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
            products.Add(product);
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
      return products;
    }

    public Product GetById(int id)
    {
            var product = new Product();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
           
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Product where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                         product = new Product(id, createTime);
                        product.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        
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
            return product;
        
    }

    public int GetCount(string whereClause = "")
    {   

            int count = 0;
            var products = new Product();
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
                comm.CommandText = "Select count(*) from Product " + whereClause;
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

    public int Save(Product product)
    {
      int primaryKey = 0;
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      SqlConnection conn = new SqlConnection();
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        SqlCommand comm = conn.CreateCommand();

        if (product.IsNew)
        {
          comm.CommandText = "INSERT INTO Product(CreateTime,Name) VALUES(@CreateTime, @Name); SELECT SCOPE_IDENTITY()";
          comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
        }
        else
        {
          comm.CommandText = "Update Product SET Name = @Name WHERE Id = @Id";
          comm.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
        }
        comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
        if (product.IsNew)
        {
          primaryKey = Convert.ToInt32(comm.ExecuteScalar());
          product.Id = primaryKey;
        }
        else
        {
          comm.ExecuteNonQuery();
          primaryKey = product.Id;
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
