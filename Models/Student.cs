using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int StudentID { get; set; }

       
        [Display(Name = "ClassName")]
        public int ClassID { get; set; }

        [NotMapped]
        public string Classes { get; set; }

    }
}
