using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Tazo.Models.Entities;

namespace Tazo.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
        }      
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Module> Modules => Set<Module>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course 
                { 
                    CourseId = 1,
                    CourseCode = "BCA1",
                    CourseTitle = "Bachelor of Computer and Information Science 1",
                    Year = 1,
                    NQF = 7
                },
                new Course
                {
                    CourseId = 2,
                    CourseCode = "BCA2",
                    CourseTitle = "Bachelor of Computer and Information Science 2",
                    Year = 2,
                    NQF = 7
                },
                new Course
                {
                    CourseId = 3,
                    CourseCode = "BCA3",
                    CourseTitle = "Bachelor of Computer and Information Science 3",
                    Year = 3,
                    NQF = 7
                },
                new Course
                {
                    CourseId = 4,
                    CourseCode = "PDDA",
                    CourseTitle = "Postgraduate Diploma in Data Analytics",
                    Year = 1,
                    NQF = 8
                });
        }

    }
}
