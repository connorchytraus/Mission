using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0,100)]
        public Int32 assi { get; set; }
        [Required]
        [Range(0, 100)]
        public Int32 grou { get; set; }
        [Required]
        [Range(0, 100)]
        public Int32 quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public Int32 midt { get; set; }
        [Required]
        [Range(0, 100)]
        public Int32 fina { get; set; }
        [Required]
        [Range(0, 100)]
        public Int32 inte { get; set; }
    }
}
