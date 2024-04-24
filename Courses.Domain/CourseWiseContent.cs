using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Domain
{
    public class CourseWiseContent
    {
        [Key]
        public int ContentId { get; set; }
        public int CourseId { get; set; }
        public string ContentTitle { get; set; }
    }
}
