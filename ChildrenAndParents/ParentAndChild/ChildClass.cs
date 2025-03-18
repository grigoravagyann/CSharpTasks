
using System.ComponentModel.DataAnnotations;

namespace ChildrenAndParents
{
    class Child
    {
        public string Name { get; private set; }
        public double Age { get; private set; }
        public Parent Father { get; private set; }
        public Parent Mother { get; private set; }
        public Child(string Name, double Age, Parent Father, Parent Mother)
        {
            if (Name is null) throw new Exception("Invalid value for Name field");
            if (Age < 0) throw new Exception("Invalid value for Age field");
            if (Father is null) throw new Exception("Invalid value for Father field");
            if (Mother is null) throw new Exception("Invalid value for Mother field");
            this.Name = Name;
            this.Age = Age;
            this.Father = Father;
            this.Mother = Mother;
        }
    }
}
