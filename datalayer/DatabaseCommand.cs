using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayer
{
    class DatabaseCommand
    {
        private MySqlCommand command;
        private string commandString;

        private DatabaseCommand()
        {

        }

        public static DatabaseCommand Init()
        {
            return new DatabaseCommand();
        }

        public DatabaseCommand Insert(object value, string field, string table)
        {
            commandString = "INSERT INTO " + table + "(" + field + ") VALUES (@value)";
            command.Parameters.AddWithValue("@value", value);

            return this;
        }

        public DatabaseCommand Insert(Array values, Array fields, string table)
        {
            int i = 0;

            commandString = "INSERT INTO " + table + "(";

            foreach (var field in fields)
            {
                commandString += field + ", ";
            }

            commandString += "VALUES (";

            foreach (var value in values)
            {
                commandString += "@value" + i + ", ";
                command.Parameters.AddWithValue("@value" + i, value.ToString());

                i++;
            }

            commandString += ")";

            return this;
        }

        public DatabaseCommand Select(string field, string table)
        {
            commandString = "SELECT " + field + " FROM " + table;

            return this;
        }

        /// <summary>
        /// Adds select query to the variable commandString
        /// </summary>
        /// <param name="fields" type="object">Can be a variable or an array</param>
        /// <param name="table" type="string"></param>
        public DatabaseCommand Select(Array fields, string table)
        {
            commandString = "SELECT ";

            foreach (var field in fields)
                commandString += field + ", ";

            commandString += "FROM " + table;

            return this;
        }

        /// <summary>
        /// Adds select query for all fields to the variable commandString
        /// </summary>
        /// <param name="table" type="string"></param>
        public DatabaseCommand Select(string table)
        {
            commandString = "SELECT * FROM " + table;

            return this;
        }

        public DatabaseCommand Update(string field, object value, string table)
        {
            commandString = "UPDATE " + table + " SET " + field + " = @value";
            command.Parameters.AddWithValue("@value", value.ToString());

            return this;
        }

        public DatabaseCommand Update(Array fields, Array values, string table)
        {
            int i = 0;

            commandString = "UPDATE " + table + " SET ";

            foreach (var field in fields)
                commandString += field + ", ";

            commandString += " = ";

            foreach (var value in values)
            {
                commandString += "@value" + i + ", ";
                command.Parameters.AddWithValue("@value" + i, value.ToString());

                i++;
            }

            return this;
        }

        public DatabaseCommand Delete(string field, string table)
        {
            commandString = "DELETE " + field + " FROM " + table;

            return this;
        }

        public DatabaseCommand Delete(Array fields, string table)
        {
            commandString = "DELETE ";

            foreach (var field in fields)
                commandString += field + ", ";

            commandString += "FROM " + table;

            return this;
        }

        public DatabaseCommand Delete(string table)
        {
            commandString = "DELETE * FROM " + table;

            return this;
        }

        public DatabaseCommand Where(string field, string operatorStr, object value)
        {
            int i = 2;

            while (commandString.Contains("value" + i))
                i++;

            if (!value.GetType().Equals(typeof(string)))
                commandString += " WHERE " + field + " " + operatorStr.ToUpper() + " CONVERT(NVARCHAR(30), @value" + i + ")";
            else
                commandString += " WHERE " + field + " " + operatorStr.ToUpper() + " @value" + i;

            command.Parameters.AddWithValue("@value" + i, value.ToString());

            return this;
        }

        public DatabaseCommand And(string field, object value, string operatorStr)
        {
            commandString += " AND";

            return this;
        }

        public DatabaseCommand Or(string field, object value, string operatorStr)
        {
            commandString += " OR";

            return this;
        }

        public DatabaseCommand Custom(string query, object value, string parameter)
        {
            commandString += query;
            command.Parameters.AddWithValue(parameter, value.ToString());

            return this;
        }

        public DatabaseCommand Custom(string query, Array values, Array parameters)
        {
            commandString += query;

            for (int i = 0; i < parameters.Length; i++)
                command.Parameters.AddWithValue(parameters.GetValue(i).ToString(), values.GetValue(i).ToString());

            return this;
        }

        public DatabaseCommand Join(string table2, string table1Field, string table2Field)
        {
            int i = 0;
            int j = i++;

            while (commandString.Contains("t" + i))
                i++;

            commandString += " t" + i + " JOIN " + table2 + " t" + j + " ON t" + i + "." + table2Field + " = t" + j + "." + table1Field; ;

            return this;
        }

        public void Execute()
        {

        }

        public DataTable ExecuteAndReturn()
        {
            return null;
        }
    }
}
