using EF_ASS01.Configuration;
using EF_ASS01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ASS01.Context
{
    internal class ItiDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<Course_Ins>(new Course_InsConfiguration());
            modelBuilder.ApplyConfiguration<Stud_Course>(new Stud_CourseConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; DataBase = Iti ; Trusted_Connection = true ; Encrypt = False");
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Ins> Course_Ins {  get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public ItiDbContext() { }
    }
}
