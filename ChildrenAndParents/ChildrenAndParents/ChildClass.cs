
namespace ChildrenAndParents
{
    class Child
    {
        string? _childName;
        double _childAge;
        Parent? _childFather;
        Parent? _childMother;
        public string Name { get => _childName!; }
        public double Age { get => _childAge; }
        public Parent Father { get => _childFather!; }
        public Parent Mother { get => _childMother!; }
        public Child() { }
        public Child(string? Name, double Age, Parent? Father, Parent? Mother)
        {
            _childName = Name;
            _childAge = Age;
            _childFather = Father;
            _childMother = Mother;
        }
    }
}
