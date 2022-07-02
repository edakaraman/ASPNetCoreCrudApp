using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class StudentContext : DbContext
    {
        //inheritance alıyoruz.
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {
                
        }
        public DbSet<Student> tbl_Student { get; set; }
        public DbSet<StuClass> tbl_Class { get; set; }

    }
}
