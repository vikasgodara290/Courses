using Courses.Domain;
using Courses.Repositry;
using Microsoft.Data.SqlClient;

namespace Courses.Services
{
    public class CourseDetailsService:ICourseDetailsService
    {
        public readonly IBaseRepositry _repositry;
        public CourseDetailsService(IBaseRepositry repositry)
        {
            _repositry = repositry;
        }
        public List<Course> courseDetails(int courseId)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@CourseId", courseId);
            var ObjList = _repositry.GetList<Course>("[dbo].[usp_GetCourseDetails]", objParam);
            return ObjList;
        }
    }
}