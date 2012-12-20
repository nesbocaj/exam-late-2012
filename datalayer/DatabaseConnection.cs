using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayer
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private MySqlConnectionStringBuilder _connectionStrBuilder;
        private string _connectionStr;
        private MySqlConnection _connection;

        private DatabaseConnection()
        {
            _connectionStrBuilder = new MySqlConnectionStringBuilder();
            _connectionStrBuilder.Server   = "localhost";
            _connectionStrBuilder.Port     = 3306;
            _connectionStrBuilder.UserID   = "exam-2012";
            _connectionStrBuilder.Password = "2012";
            _connectionStrBuilder.Database = "exam-late-2012";

            _connectionStr = _connectionStrBuilder.ConnectionString;

            _connection = new MySqlConnection(_connectionStr);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseConnection();
                return _instance;
            }
        }

        public MySqlConnection MySql
        {
            get { return _connection; }
        }

        public bool Open()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException me)
            {
                Debug.WriteLine("DatabaseConnection - Open: {0}", me);
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException me)
            {
                Debug.WriteLine("DatabaseConnection - Close: {0}", me);
                return false;
            }
        }
    }
}
