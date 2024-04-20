using Microsoft.Data.SqlClient;

namespace Courses.Repositry
{
    public interface IBaseRepositry
    {
        public List<T> GetList<T>(string storedProcedureName, params SqlParameter[] sqlParameters);
    }
}
