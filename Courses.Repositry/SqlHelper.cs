using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Repositry
{
    public class SqlHelper
    {
        public static List<T> ExecuteStoredProcedureReturnList<T>(string _connectionString,string storedProcedureName,params SqlParameter[] sqlParameters)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                using(var cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedureName;

                    if (sqlConnection.State != ConnectionState.Open)
                    { sqlConnection.Open(); }

                    foreach (var parameter in sqlParameters)
                    {
                        parameter.Value = parameter.Value ?? DBNull.Value;
                        cmd.Parameters.Add(parameter);
                    }

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var list = DataReaderMapToList<T>(reader);
                        sqlConnection.Close();
                        return list;
                    }
                }    
            }
        }


        public static List<T> DataReaderMapToList<T>(SqlDataReader reader)
        {
            List<T> list = new List<T>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (reader[prop.Name] != null && !Equals(reader[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(obj, reader[prop.Name], null);
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            return new List<T>();
        }
    }
}
