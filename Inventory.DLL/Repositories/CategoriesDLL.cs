using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Repositories
{
    public class CategoriesDLL
    {
        private string photoFilePath;

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
                comm.CommandText = "Delete from Categories where Id = " + id.ToString();
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


        public List<Categories> GetAll(string whereClause = "")
        {
            var categoriess = new List<Categories>();
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
                comm.CommandText = "Select * from Categories" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        var categories = new Categories(id, createTime);
                        categories.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        categories.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        
                        categoriess.Add(categories);
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
            return categoriess;
        }


        public Categories GetById(int id)
        {
            var categories = new Categories();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Categories where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        categories = new Categories(id, createTime);
                        categories.Name = reader["Name"] is DBNull ? null : reader["Name"].ToString();
                        categories.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        byte[] picture = File.ReadAllBytes(photoFilePath);

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
            return categories;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var categories = new Categories();
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
                comm.CommandText = "Select count(*) from Categories " + whereClause;
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

        public int Save(Categories categories)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (categories.IsNew)
                {
                    comm.CommandText = "INSERT INTO Categories(CreateTime, Name, Description, Picture) VALUES(@CreateTime, @Name, @Description, @Picture); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Categories SET Name = @Name, Description = @Description, Picture = @Picture WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = categories.Id;
                }
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = categories.Name;
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = categories.Description;
                comm.Parameters.Add("@Picture", SqlDbType.Image).Value = categories.Picture;
                if (categories.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    categories.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = categories.Id;
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

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] picture = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return picture;

        }

    }
}
