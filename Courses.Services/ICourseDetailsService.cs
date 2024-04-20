using Courses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Services
{
    public interface ICourseDetailsService
    {
        public List<Course> courseDetails(int courseId);
    }
}
