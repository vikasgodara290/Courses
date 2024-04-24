using Microsoft.Data.SqlClient;

namespace Courses.Repositry
{
    public interface IBaseRepositry
    {
        public List<T> GetList<T>(string storedProcedureName, params SqlParameter[] sqlParameters);
        public List<T> GetCourseWiseContentList<T>(string storedProcedureName, SqlParameter[] sqlParameters);
        public List<T> GetContenteWiseFilesList<T>(string storedProcedureName, SqlParameter[] sqlParameters);   
    }
}
