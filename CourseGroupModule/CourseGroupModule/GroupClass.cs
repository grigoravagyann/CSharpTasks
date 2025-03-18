
namespace CourseGroupModule
{
    class Group
    {
        public string Name { get; private set; }
        public int StudentsNumber { get; private set; }
        public Course[] Courses { get; private set; }
        public Group(string Name, int StudentsNumber, params Course[] Courses)
        {
            this.Name = Name;
            this.StudentsNumber = StudentsNumber;
            this.Courses = Courses;
        }
    }
}
