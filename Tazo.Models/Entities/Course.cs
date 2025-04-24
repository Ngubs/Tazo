using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tazo.Models.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseTitle { get; set; }
        public int Year { get; set; }
        public int NQF { get; set; }
        //One to Many relationship
        public List<Module>? Modules { get; set; }
    }
    
}
