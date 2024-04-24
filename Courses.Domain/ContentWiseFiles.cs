using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Domain
{
    public class ContentWiseFiles
    {
        [Key]
        public int FileId { get; set; }
        public int ContentId { get; set; }
        public string FileTitle { get; set; }
    }
}
