using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Inventory.DLL
{
    public class DataAccessManager
    {
        private SqlConnection connection;

        private SqlTransaction sqlTransaction;
        public DataAccessManager() 
        { 

        }

        public DataAccessManager(SqlConnection conn)
        {
            connection = conn;
        }

        public SqlConnection GetSqlConnection()
        {
            if(connection == null)
            {
                var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                connection = new SqlConnection(myConnectionString);
            }
            return connection;
        }
        
        public void OpenTransaction()
        {
            if(sqlTransaction == null)
            {
                OpenConnection();
                sqlTransaction = connection.BeginTransaction();
            }
        }

        public void CommitTransaction()
        {
            if (sqlTransaction != null)
            {
                sqlTransaction.Commit();
                sqlTransaction.Dispose();
                sqlTransaction = null;
            }
            CloseConnection();
        }

        public void RollbackTransaction()
        {
            if (sqlTransaction != null)
            {
                sqlTransaction.Rollback();
                sqlTransaction.Dispose();
                sqlTransaction = null;
            }
            CloseConnection();
        }

        public void OpenConnection()
        {
            GetSqlConnection();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
            }
        }
    }
}
