using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEFSQL.Models
{
    public class Grade
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeId { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string GradeName { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal GradeValue { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string StudentId { get; set; }
    }
}
