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
        comm.CommandText = "SELECT P.*, S.Name AS SupplierName, C.Name AS CategoryName from Product P " +
                           "left join Supplier S ON P.SupplierId = S.Id " +
                           "left join Categories C ON P.CategoryId = C.Id " + whereClause;
        using (SqlDataReader reader = comm.ExecuteReader())
        {
          while (reader != null && reader.Read())
          {
            int id = Convert.ToInt32(reader["id"]);
            DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
            var product = new Product(id, createTime);
            product.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
            product.SupplierId = reader["SupplierId"] is DBNull ? 0 : Convert.ToInt32(reader["SupplierId"]);
            product.CategoryId = reader["CategoryId"] is DBNull ? 0 : Convert.ToInt32(reader["CategoryId"]);
            product.Quantity = reader["Quantity"] is DBNull ? null : reader["Quantity"].ToString();
            product.UnitPrice = reader["UnitPrice"] is DBNull ? 0 :Convert.ToDouble(reader["UnitPrice"]);
            product.UnitInStock = reader["UnitInStock"] is DBNull ? 0 : Convert.ToInt32 (reader["UnitInStock"]);
            product.UnitsOnOrder = reader["UnitsOnOrder"] is DBNull ? 0 :Convert.ToInt32(reader["UnitsOnOrder"]);
            product.ReorderLevel = reader["ReorderLevel"] is DBNull ? 0 :Convert.ToInt32(reader["ReorderLevel"]);
            product.Discontinued = reader["Discontinued"] is DBNull ? false :Convert.ToBoolean (reader["Discontinued"]);
            product.SupplierName = reader["SupplierName"] is DBNull ? string.Empty : Convert.ToString(reader["SupplierName"]);
            product.CategoryName = reader["categoryName"] is DBNull ? string.Empty : Convert.ToString(reader["CategoryName"]);
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
                comm.CommandText = "SELECT P.*, S.Name AS SupplierName, C.Name AS CategoryName from Product P " +
                           "left join Supplier S ON P.SupplierId = S.Id " +
                           "left join Categories C ON P.CategoryId = C.Id Where P.Id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        product = new Product(id, createTime);
                        product.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        product.SupplierId = reader["SupplierId"] is DBNull ? 0 : Convert.ToInt32(reader["SupplierId"]);
                        product.CategoryId = reader["CategoryId"] is DBNull ? 0 : Convert.ToInt32(reader["CategoryId"]);
                        product.Quantity = reader["Quantity"] is DBNull ? null : reader["Quantity"].ToString();
                        product.UnitPrice = reader["UnitPrice"] is DBNull ? 0 : Convert.ToDouble(reader["UnitPrice"]);
                        product.UnitInStock = reader["UnitInStock"] is DBNull ? 0 : Convert.ToInt32(reader["UnitInStock"]);
                        product.UnitsOnOrder = reader["UnitsOnOrder"] is DBNull ? 0 : Convert.ToInt32(reader["UnitsOnOrder"]);
                        product.ReorderLevel = reader["ReorderLevel"] is DBNull ? 0 : Convert.ToInt32(reader["ReorderLevel"]);
                        product.Discontinued = reader["Discontinued"] is DBNull ? false : Convert.ToBoolean(reader["Discontinued"]);
                        product.SupplierName = reader["SupplierName"] is DBNull ? string.Empty : Convert.ToString(reader["SupplierName"]);
                        product.CategoryName = reader["categoryName"] is DBNull ? string.Empty : Convert.ToString(reader["CategoryName"]);

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
          comm.CommandText = "INSERT INTO Product(CreateTime, Name, SupplierId, CategoryId, Quantity, UnitPrice, UnitInStock, UnitsOnOrder, ReorderLevel, Discontinued )" +
                        " VALUES (@CreateTime, @Name, @SupplierId, @CategoryId, @Quantity, @UnitPrice, @UnitInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued); SELECT SCOPE_IDENTITY()";
          comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
        }
        else
        {
          comm.CommandText = "Update Product SET Name = @Name, SupplierId = @SupplierId, CategoryId = @CategoryId, Quantity =@Quantity, UnitPrice = @UnitPrice, UnitInStock = @UnitInStock, UnitsOnOrder =@UnitsOnOrder, ReorderLevel= @ReorderLevel, Discontinued = @Discontinued   WHERE Id = @Id";
          comm.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
        }
        comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
        comm.Parameters.Add("@SupplierId", SqlDbType.Int).Value = product.SupplierId;
        comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = product.CategoryId;
        comm.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
        comm.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = product.UnitPrice;
        comm.Parameters.Add("@UnitInStock", SqlDbType.Int).Value = product.UnitInStock;
        comm.Parameters.Add("@UnitsOnOrder", SqlDbType.Int).Value = product.UnitsOnOrder;
        comm.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value = product.ReorderLevel;
        comm.Parameters.Add("@Discontinued", SqlDbType.Bit).Value = product.Discontinued;

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
