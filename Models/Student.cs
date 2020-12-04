using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string Sname { get; set; }
        public DateTime SDOB { get; set; }
        public double Contact { get; set; }

    }
}
