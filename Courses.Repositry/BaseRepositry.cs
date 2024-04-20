using Microsoft.Data.SqlClient;

namespace Courses.Repositry
{
    public class BaseRepositry : IBaseRepositry
    {
        private string  _connectionString;
        public BaseRepositry(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<T> GetList<T>(string storedProcedureName, params SqlParameter[] sqlParameters)
        {
            var list = SqlHelper.ExecuteStoredProcedureReturnList<T>(_connectionString,storedProcedureName,sqlParameters);
            return list;
        }
    }
}