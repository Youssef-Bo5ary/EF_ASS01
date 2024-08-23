using EF_ASS01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_ASS01.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(nameof(Student.Id)).UseIdentityColumn(1, 1);
            builder.Property(E => E.Fname).HasColumnType("Varchar").HasMaxLength(50);

            builder.Property(E => E.Lname) .HasColumnType("Varchar").HasMaxLength(50);
            builder.Property(E => E.Address).HasColumnType("Varchar").HasMaxLength(50);
            builder.Property(E => E.Age) .HasColumnType("Age").HasDefaultValue(25);
            builder.Property(E => E.DeptId).HasColumnType("DepIdentity");
        }
    }

    internal class Course_InsConfiguration : IEntityTypeConfiguration<Course_Ins>
    {
        public void Configure(EntityTypeBuilder<Course_Ins> builder)
        {
            builder.Property(C => C.InsId).UseIdentityColumn(1, 1);
            builder.Property(C => C.CourseId);
            builder.Property(C => C.Evaluate).HasColumnType("Rank");
        }

    }

    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.Property(S => S.StudId).UseIdentityColumn(1, 1);
            builder.Property(S => S.CourseId);
            builder.Property(S => S.Grade).HasColumnType("Grade");
        }
    }
}
