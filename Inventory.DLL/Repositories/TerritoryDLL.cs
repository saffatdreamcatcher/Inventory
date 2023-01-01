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
    public class TerritoryDLL
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
                comm.CommandText = "Delete from Territory where Id = " + id.ToString();
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

        public List<Territory> GetAll(string whereClause = "")
        {
            List<Territory> territories = new List<Territory>();
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
                comm.CommandText = "Select Territory.*, Region.Description AS RegionName from Territory " +
                                   "inner join Region on Territory.RegionId = Region.Id " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        var territoryy = new Territory(id, createTime);
                        territoryy.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        territoryy.RegionId = Convert.ToInt32(reader["RegionId"]);
                        territoryy.RegionName = reader["RegionName"].ToString();
                        territories.Add(territoryy);
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
            return territories;
        }


        public Territory GetById(int id)
        {
            var territory = new Territory();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select Territory.*, Region.Description AS RegionName from Territory " +
                                   "inner join Region on Territory.RegionId = Region.Id " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        territory = new Territory(id, createTime);
                        territory.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        territory.RegionId = Convert.ToInt32(reader["RegionId"]);
                        territory.RegionName = reader["RegionName"].ToString();
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
            return territory;

        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var territory = new Territory();
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
                comm.CommandText = "Select count(*) from Territory " + whereClause;
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

        public int Save(Territory territory)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (territory.IsNew)
                {
                    comm.CommandText = "INSERT INTO Territory(CreateTime, Description, RegionId) VALUES(@CreateTime, @Description, @RegionId); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Territory SET Description = @Description, RegionId = @RegionId WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = territory.Id;
                }
                
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = territory.Description;
                comm.Parameters.Add("@RegionId", SqlDbType.VarChar).Value = territory.RegionId;

                if (territory.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    territory.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = territory.Id;
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
