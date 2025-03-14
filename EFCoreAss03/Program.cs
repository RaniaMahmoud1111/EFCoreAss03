using EFCoreAss03.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAss03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Mapping relations

            #region OneToMany mandatory in both sides( Student --> Department )


            #region  By Convention (Default Mapping)
            //    //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            // class Student
            // { 
            //    // Foreign key property (optional)
            //public int DepartmentID { get; set; }//fk

            ////Navigation property {one}
            //public Department Department { get; set; }
            // }
            //// *********************************************
            //class Department 
            //{
            //    //navigation properity [Many]
            //    public ICollection<Student> Student { get; set; }
            // }
            #endregion


            #region 2.Using Data Annotations
            ////1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            ////2. Using Data Annotations You can explicitly define the foreign key using the[ForeignKey] attribute
            //class Student
            //{
            //    [ForeignKey(nameof(Department))]
            //public int DepartmentID { get; set; }//fk

            ////Navigation property {one}
            //public Department Department { get; set; }
            //}
            //// *********************************************
            //class Department
            //{
            //    //navigation properity [many]
            //    public ICollection<Student> Student { get; set; }
            //}
            #endregion


            #region Fluent Api
            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    base.OnModelCreating(modelBuilder);

            //    modelBuilder.Entity<Student>()
            //        .HasOne(s => s.Department)
            //        .WithMany(d => d.Students)
            //        .HasForeignKey(s => s.DepartmentID)
            //        .OnDelete(DeleteBehavior.Cascade);

            //    // this addtional not nessacry 
            //    modelBuilder.Entity<Department>()
            //        .HasMany(d=>d.Students)
            //        .WithOne(s=>s.Department)
            //        .HasForeignKey(s=>s.DepartmentID)
            //        .OnDelete(DeleteBehavior.Cascade);



            //}


            #endregion


            #endregion


            #region OneToMany mandatory in both sides( Instructor --> Department )


            #region  1. By Convention (Default Mapping)
            //    //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            //     class Instructor
            //{
            //    // Foreign key property (optional)
            //    public int DepartmentID { get; set; }//fk

            //    //Navigation property {one}
            //    public Department Department { get; set; }
            //}
            //// *********************************************
            //class Department
            //{
            //    //navigation properity [Many]
            //    public ICollection<Instructor> Instructor { get; set; }
            //}
            #endregion


            #region 2.Using Data Annotations
            //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            //2. Using Data Annotations You can explicitly define the foreign key using the[ForeignKey] attribute
            //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            //   class Instructor
            //   {
            //     [ForeignKey(nameof(Department))]
            //     public int DepartmentID { get; set; }//fk

            //     //Navigation property {one}
            //     public Department Department { get; set; }
            //   }

            // // *********************************************

            //class Department
            // {
            //     //navigation properity [Many]
            //     public ICollection<Instructor> Instructors { get; set; }
            // }
            #endregion


            #region  3.Fluent Api
            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //
            //modelBuilder.Entity<Instructor>()
            //        .HasOne(i=>i.Department)
            //        .WithMany(d=>d.Instructors)
            //        .HasForeignKey(i=>i.DepartmentID)
            //        .OnDelete(DeleteBehavior.Cascade);

            //// or this way

            //modelBuilder.Entity<Department>()
            //        .HasMany(d=>d.Instructors)
            //        .WithOne(i=>i.Department)
            //        .HasForeignKey(i=>i.DepartmentID)
            //        .OnDelete(DeleteBehavior.Cascade);



            //}


            #endregion


            #endregion


            #region OneToOne Optional in side  mandatory in other side ( Instructor --> Department( 1 (O) ===>  1(M) ) )


            #region  1. By Convention (Default Mapping)
            //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            //class Instructor
            //{
            //    //Navigation property {one}
            //    public Department? Department { get; set; }
            //}
            //// *********************************************
            //class Department
            //{
            //    //ef understand the fk if i called (InstructorId)
            //    public int InstructorId { get; set; }//fk

            //    //navigation properity [one]
            //    //EF core must be instructed by instractor [ total participation ]
            //    public Instructor Instructor { get; set; }

            //}
            #endregion


            #region 2.Using Data Annotations
            //1.EF Core automatically detects a one-to-many relationship when a navigation property is included in both entities
            //2. Using Data Annotations You can explicitly define the foreign key using the[ForeignKey] attribute
            //class Instructor
            //{
            //    //Navigation property {one}
            //    public Department? Department { get; set; }
            //}
            //// *********************************************
            //class Department
            //{
            //    [ForeignKey(nameof(Instructor))]
            //    public int InstructorId { get; set; }//fk

            //    //navigation properity [one]
            //    //EF core must be instructed by instractor [ total part)icipation ]
            //    public Instructor Instructor { get; set; }

            //}
            #endregion


            #region  3.Fluent Api
            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //

            //modelBuilder.Entity<Department>()
            //        .HasOne(d => d.Instructor)
            //        .WithOne(i => i.Department)
            //        .HasForeignKey<Department>(d => d.InstructorId);

            //    // or 
            //    modelBuilder.Entity<Instructor>()
            //        .HasOne(i => i.Department)
            //        .WithOne(d => d.Instructor)
            //        .HasForeignKey<Department>(d => d.InstructorId);



            //}


            #endregion


            #endregion


            //**********************************************

            #region OneToOne mandatory in both sides( Course --> Topic )


            #region  By Convention (Default Mapping)
            // we cannot make it by convention
            #endregion


            #region 2.Using Data Annotations
            //[Owned]
            //internal class Topic
            //{
            //    public string Name { get; set; }
            //}
            //internal class Course
            //{
            //    //Navigation property [one]
            //    public Topic Topic { get; set; }
            //}


            #endregion


            #region Fluent Api
            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Course>()
            //        .OwnsOne(c => c.Topic);



            //}


            #endregion


            #endregion


            #region Many to Many ( Course --> Student )


            #region  By Convention (Default Mapping) Implicit Join Table
            // EF Core automatically creates a join table if you define a List<T> on both sides. No need to create a separate entity
            //but in this example we cannot make it by convention as there is an attribute on relation like grade 

            //public class Student
            //{
            //    public List<Course> Courses { get; set; } = new();
            //}

            //public class Course
            //{
            //    public List<Student> Students { get; set; } = new();
            //}

            #endregion


            #region 2.Using Data Annotations
            //public class Student
            //{
            //    public int Id { get; set; }
            //    public List<CourseStudent> CourseStudents { get; set; } = new();
            //}

            //public class Course
            //{
            //    public int Id { get; set; }
            //    public List<CourseStudent> CourseStudents { get; set; } = new();
            //}


            //public class CourseStudent
            //{
            //    [Key, Column(Order = 0)] // Composite Primary Key (Part 1)
            //    public int CourseId { get; set; }

            //    [Key, Column(Order = 1)] // Composite Primary Key (Part 2)
            //    public int StudentId { get; set; }

            //    [ForeignKey("CourseId")]
            //    public Course Course { get; set; }

            //    [ForeignKey("StudentId")]
            //    public Student Student { get; set; }

            //    public double Grade { get; set; } // Additional property
            //}

            #endregion


            #region Fluent Api (Explicit Join Table)

            //public class Student
            //{
            //    public int Id { get; set; }
            //    public List<CourseStudent> CourseStudents { get; set; } = new();
            //}

            //public class Course
            //{
            //    public int Id { get; set; }
            //    public List<CourseStudent> CourseStudents { get; set; } = new();
            //}

            //public class CourseStudent
            //{
            //    public int CourseId { get; set; }
            //    public int StudentId { get; set; }

            //    public Course Course { get; set; }
            //    public Student Student { get; set; }

            //    public double Grade { get; set; } // Additional property
            //}



            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    base.OnModelCreating(modelBuilder);

            //composite key 
            //    modelBuilder.Entity<CourseStudent>()
            //            .HasKey(cs => new { cs.CourseId, cs.StudentId });

            //        // configure the relationship
            //        modelBuilder.Entity<CourseStudent>()
            //            .HasOne(cs => cs.Course)
            //            .WithMany(c => c.CourseStudents)
            //            .HasForeignKey(cs => cs.CourseId);


            //modelBuilder.Entity<CourseStudent>()
            //            .HasOne(cs => cs.Student)
            //            .WithMany(s=>s.CourseStudents)
            //            .HasForeignKey(cs=>cs.StudentId);





            //}


            #endregion


            #endregion


            #region Many to Many ( Course --> Instructor )


            #region  By Convention (Default Mapping) Implicit Join Table-Not Possible Here
            //EF Core automatically creates a join table if you define List<T> on both sides.However, this approach does not support additional attributes (Evaluation), so we must use an explicit join table instead

            #endregion


            #region 2.Using Data Annotations
            //public class Instructor
            //{
            //    public int Id { get; set; }
            //  public ICollection<CourseInstructor> CourseInstructors { get; set; }
            //}

            //public class Course
            //{
            //    public int Id { get; set; }
            // public ICollection<CourseInstructor> CourseInstructors { get; set; }
            //}


            //internal class CourseInstructor
            //{

            //    [Key, Column(Order = 0)] // Composite Primary Key (Part 1)
            //    public int CourseId { get; set; }

            //    [Key, Column(Order = 1)] // Composite Primary Key (Part 2)
            //    public int InstructorId { get; set; }

            //    [ForeignKey("CourseId")]
            //    public Course Course { get; set; }

            //    [ForeignKey("InstructorId")]
            //    public Instructor Instructor { get; set; }

            //    public double Evaluate { get; set; } // Additional attribute


            //}
            #endregion


            #region Fluent Api (Explicit Join Table)

            //public class Instructor
            //{
            //    public int Id { get; set; }
            //  public ICollection<CourseInstructor> CourseInstructors { get; set; }
            //}

            //public class Course
            //{
            //    public int Id { get; set; }
            // public ICollection<CourseInstructor> CourseInstructors { get; set; }
            //}


            //internal class CourseInstructor
            //{

            //    public int CourseId { get; set; }

            //    public int InstructorId { get; set; }

            //    public Course Course { get; set; }

            //    public Instructor Instructor { get; set; }

            //    public double Evaluate { get; set; } // Additional attribute


            //}

            //    // in myclass that implement  
            //public DbSet<Student> Students { get; set; }
            //public DbSet<Course> Courses { get; set; }
            //public DbSet<Instructor> Instructors { get; set; }
            //public DbSet<Department> Departments { get; set; }
            //public DbSet<Topic> Topics { get; set; }


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    base.OnModelCreating(modelBuilder);

            //compoite key
            //    modelBuilder.Entity<CourseInstructor>()
            //            .HasKey(ci=> new {ci.CourseId,ci.InstructorId });
            //        // relationship
            //        modelBuilder.Entity<CourseInstructor>()
            //            .HasOne(ci => ci.Course)
            //            .WithMany(c => c.CourseInstructors)
            //            .HasForeignKey(ci => ci.CourseId);

            //modelBuilder.Entity<CourseInstructor>()
            //            .HasOne(ci=>ci.Instructor)
            //            .WithMany(i=>i.CourseInstructors)
            //            .HasForeignKey(ci=>ci.InstructorId);





            //}


            #endregion


            #endregion





            #endregion
        }


    }
}