
namespace ChildrenAndParents
{
    class Parent
    {
        string? _parentName;
        double _parentAge;
        double _parentSalary;
        public string Name { get => _parentName!; }
        public double Age { get => _parentAge; }
        public double Salary { get => _parentSalary; }
        public Parent() { }
        public Parent(string? Name, double Age, double Salary)
        {
            _parentName = Name;
            _parentAge = Age;
            _parentSalary = Salary;
        }
    }
}
