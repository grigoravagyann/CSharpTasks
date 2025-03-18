
namespace ChildrenAndParents
{
    class Parent
    {
        public string Name { get; private set; }
        public double Age { get; private set; }
        public double Salary { get; private set; }
        public Parent(string Name, double Age, double Salary)
        {
            if (Age < 0) throw new Exception("Invalid value for Age field");
            if (Name is null) throw new Exception("Invalid value for Name field");
            if (Salary < 0) throw new Exception("Invalid value for Salary field");
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }
    }
}