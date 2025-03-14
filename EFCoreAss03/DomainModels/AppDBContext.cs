using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss03.DomainModels
{
    internal class AppDBContext:DbContext
    {
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-95A74GO;Initial Catalog=Ass03EFCore;Integrated Security=True;TrustServerCertificate=True;");

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department>Departments { get; set; }
        public DbSet<Topic> Topics{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Course>()
                .OwnsOne(c => c.Topic);


            //composite key 
            modelBuilder.Entity<CourseStudent>()
                .HasKey(cs => new { cs.CourseId, cs.StudentId });

            // configure the relationship
            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(cs => cs.CourseId);


            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(s=>s.CourseStudents)
                .HasForeignKey(cs=>cs.StudentId);
                


          ////compoite key
          //  modelBuilder.Entity<CourseInstructor>()
          //      .HasKey(ci=> new {ci.CourseId,ci.InstructorId});
          //  // relationship
          //  modelBuilder.Entity<CourseInstructor>()
          //      .HasOne(ci => ci.Course)
          //      .WithMany(c => c.CourseInstructors)
          //      .HasForeignKey(ci => ci.CourseId);

          //  modelBuilder.Entity<CourseInstructor>()
          //      .HasOne(ci=>ci.Instructor)
          //      .WithMany(i=>i.CourseInstructors)
          //      .HasForeignKey(ci=>ci.InstructorId);



               

        }


    }
}
