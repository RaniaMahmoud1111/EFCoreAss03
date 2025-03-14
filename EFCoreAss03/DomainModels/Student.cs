using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss03.DomainModels
{ //Pocp class is a  class that has  properities only plain old clr object 

    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }


        // [ForeignKey(nameof(Department))]
        // Foreign key property (optional)

        public int DepartmentID { get; set; }//fk

        //Navigation property {one}
        public Department Department { get; set; }

        //Navigation property  many
        public ICollection<CourseStudent> CourseStudents { get; set; }

       

    }

  

}
