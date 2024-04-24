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
    public class FileService: IFileService
    {
        private readonly IBaseRepositry _baseRepositry;
        public FileService(IBaseRepositry baseRepositry)
        {
            _baseRepositry = baseRepositry;
        }
        public List<ContentWiseFiles> GetContentWiseFiles(int contentId)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@ContentId", contentId);
            var objList = _baseRepositry.GetContenteWiseFilesList<ContentWiseFiles>("[dbo].[usp_GetContentWiseFilesList]", objParam);
            return objList;
        }
    }
}
