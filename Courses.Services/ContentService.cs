using Courses.Domain;
using Courses.Repositry;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
    public class ContentService : IContentService
    {
        private readonly IBaseRepositry _baseRepositry;
        public ContentService(IBaseRepositry baseRepositry)
        {
            _baseRepositry = baseRepositry;
        }
        public List<CourseWiseContent> GetCourseWiseList(int courseId)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@CourseId",courseId);
            var objList = _baseRepositry.GetCourseWiseContentList<CourseWiseContent>("[dbo].[usp_GetCourseWiseContentList]", objParam);
            return objList;
        }
    }
}
