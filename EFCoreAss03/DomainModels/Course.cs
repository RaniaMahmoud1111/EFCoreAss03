namespace EFCoreAss03.DomainModels
{ //Pocp class is a  class that has  properities only plain old clr object 

    internal class Course
    {
        public int Id { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation property [one]
        public Topic Topic { get; set; }

        //Navigation property many
        public ICollection<CourseStudent> CourseStudents { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }

    }

}
