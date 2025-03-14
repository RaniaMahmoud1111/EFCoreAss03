namespace EFCoreAss03.DomainModels
{ //Pocp class is a  class that has  properities only plain old clr object 
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  Bouns { get; set; }
        public decimal  Salary { get; set; }
        public string Address { get; set; }

        public int HourRate { get; set; }
        public string? Evaluate { get; set; }

        public int DepartmentID { get; set; }//fk

        // navigation pro [one]
        //EF : Instruct may instruct deparment or not [partial participation]
        public Department? InstructDepartment { get; set; }
        


        // navigation pro [one]
        public Department Department { get; set; }



        public ICollection<CourseInstructor> CourseInstructors {  get; set; }




    }

}
