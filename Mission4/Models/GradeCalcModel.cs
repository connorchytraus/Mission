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
        public float assi { get; set; }
        [Required]
        [Range(0, 100)]
        public float grou { get; set; }
        [Required]
        [Range(0, 100)]
        public float quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public float midt { get; set; }
        [Required]
        [Range(0, 100)]
        public float fina { get; set; }
        [Required]
        [Range(0, 100)]
        public float inte { get; set; }
    }
}
