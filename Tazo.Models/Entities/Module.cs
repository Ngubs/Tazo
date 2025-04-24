using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tazo.Models.Entities
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string? ModuleCode { get; set; }
        public string? ModuleTitle { get; set; }
        public int Credits { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

    }
}
