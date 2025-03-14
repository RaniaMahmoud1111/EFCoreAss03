namespace EFCoreAss03.DomainModels
{ //Pocp class is a  class that has  properities only plain old clr object 
 
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        //ef understand the fk if i called (InstructorId)
        public int InstructorId { get; set; }//fk

        //navigation properity [one]
        //EF core must be instructed by instractor [ total participation ]
        public Instructor Instructor { get; set; }


        //navigation properity [many]
        public ICollection<Instructor> Instructors { get; set; }

        //navigation properity [many]
        public ICollection<Student> Students { get; set; }


    }

}
