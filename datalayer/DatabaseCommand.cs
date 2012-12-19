using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayer
{
    class DatabaseCommand
    {
        private DatabaseConnection _connection;
        private MySqlCommand _command;
        private string _commandStr;

        private DatabaseCommand()
        {
            _connection = DatabaseConnection.Instance;

            _command = new MySqlCommand();
            _command.Connection = _connection.MySql;
        }

        public static DatabaseCommand Init()
        {
            return new DatabaseCommand();
        }

        public DatabaseCommand Insert(object value, string field, string table)
        {
            _commandStr = "INSERT INTO " + table + "(" + field + ") VALUES (@value)";
            _command.Parameters.AddWithValue("@value", value);

            return this;
        }

        public DatabaseCommand Insert(Array values, Array fields, string table)
        {
            int i = 0;

            _commandStr = "INSERT INTO " + table + "(";

            foreach (var field in fields)
            {
                _commandStr += field + ", ";
            }

            _commandStr += "VALUES (";

            foreach (var value in values)
            {
                _commandStr += "@value" + i + ", ";
                _command.Parameters.AddWithValue("@value" + i, value.ToString());

                i++;
            }

            _commandStr += ")";

            return this;
        }

        public DatabaseCommand Select(string field, string table)
        {
            _commandStr = "SELECT " + field + " FROM " + table;

            return this;
        }

        /// <summary>
        /// Adds select query to the variable commandString
        /// </summary>
        /// <param name="fields" type="object">Can be a variable or an array</param>
        /// <param name="table" type="string"></param>
        public DatabaseCommand Select(Array fields, string table)
        {
            _commandStr = "SELECT ";

            foreach (var field in fields)
                _commandStr += field + ", ";

            _commandStr += "FROM " + table;

            return this;
        }

        /// <summary>
        /// Adds select query for all fields to the variable commandString
        /// </summary>
        /// <param name="table" type="string"></param>
        public DatabaseCommand Select(string table)
        {
            _commandStr = "SELECT * FROM " + table;

            return this;
        }

        public DatabaseCommand Update(string field, object value, string table)
        {
            _commandStr = "UPDATE " + table + " SET " + field + " = @value";
            _command.Parameters.AddWithValue("@value", value.ToString());

            return this;
        }

        public DatabaseCommand Update(Array fields, Array values, string table)
        {
            int i = 0;

            _commandStr = "UPDATE " + table + " SET ";

            foreach (var field in fields)
                _commandStr += field + ", ";

            _commandStr += " = ";

            foreach (var value in values)
            {
                _commandStr += "@value" + i + ", ";
                _command.Parameters.AddWithValue("@value" + i, value.ToString());

                i++;
            }

            return this;
        }

        public DatabaseCommand Delete(string field, string table)
        {
            _commandStr = "DELETE " + field + " FROM " + table;

            return this;
        }

        public DatabaseCommand Delete(Array fields, string table)
        {
            _commandStr = "DELETE ";

            foreach (var field in fields)
                _commandStr += field + ", ";

            _commandStr += "FROM " + table;

            return this;
        }

        public DatabaseCommand Delete(string table)
        {
            _commandStr = "DELETE * FROM " + table;

            return this;
        }

        public DatabaseCommand Where(string field, string operatorStr, object value)
        {
            int i = 2;

            while (_commandStr.Contains("value" + i))
                i++;

            if (!value.GetType().Equals(typeof(string)))
                _commandStr += " WHERE " + field + " " + operatorStr.ToUpper() + " CONVERT(NVARCHAR(30), @value" + i + ")";
            else
                _commandStr += " WHERE " + field + " " + operatorStr.ToUpper() + " @value" + i;

            _command.Parameters.AddWithValue("@value" + i, value.ToString());

            return this;
        }

        public DatabaseCommand And(string field, object value, string operatorStr)
        {
            _commandStr += " AND";

            return this;
        }

        public DatabaseCommand Or(string field, object value, string operatorStr)
        {
            _commandStr += " OR";

            return this;
        }

        public DatabaseCommand Custom(string query, object value, string parameter)
        {
            _commandStr += query;
            _command.Parameters.AddWithValue(parameter, value.ToString());

            return this;
        }

        public DatabaseCommand Custom(string query, Array values, Array parameters)
        {
            _commandStr += query;

            for (int i = 0; i < parameters.Length; i++)
                _command.Parameters.AddWithValue(parameters.GetValue(i).ToString(), values.GetValue(i).ToString());

            return this;
        }

        public DatabaseCommand Join(string table2, string table1Field, string table2Field)
        {
            int i = 0;
            int j = i++;

            while (_commandStr.Contains("t" + i))
                i++;

            _commandStr += " t" + i + " JOIN " + table2 + " t" + j + " ON t" + i + "." + table2Field + " = t" + j + "." + table1Field; ;

            return this;
        }

        public void Execute()
        {
            try
            {
                if (DatabaseConnection.Instance.Open())
                {
                    _command.CommandText = _commandStr;
                    _command.ExecuteNonQuery();
                    _connection.Close();
                }
            }

            catch (MySqlException me) { Debug.WriteLine("DatabaseCommand: {0}", me); }
        }

        public DataTable ExecuteAndReturn()
        {
            try
            {
                if (DatabaseConnection.Instance.Open())
                {
                    _command.CommandText = _commandStr;
                    MySqlDataReader datareader = _command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(datareader);

                    DatabaseConnection.Instance.Close();

                    return dataTable;
                }
                else
                    return null;
            }

            catch (MySqlException me)
            {
                Debug.WriteLine("DatabaseCommand: {0}", me);
                return null;
            }
        }
    }
}
