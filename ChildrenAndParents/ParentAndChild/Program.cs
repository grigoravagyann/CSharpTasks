/*
Create Parent and Child classes, the first of which contains information about the parent, the second - about the child.
Create a static array of Children consisting of 10 elements
    1) Print a list of children whose father and mother's combined age does not exceed 70.
    2) Find the salary of the father of the oldest child
    3) Find the data of the child with the highest family income
    4) Swap the positions of the youngest and oldest children in the array, printing the total array.
*/

using ChildrenAndParents;

class Program
{
    static void Main()
    {
        Child[] children = new Child[10];

        for (int i = 0; i < children.Length; ++i)
        {
            children[i] = new Child($"Child {i}", -1, new Parent($"Father {i}", i + 30, i * 1000), new Parent($"Mother {i}", i + 25, i * 1000));
        }

        ChildrenMethods.PrintByParentsAge(70, children);    // 1)
        ChildrenMethods.MaxAgeFatherSalary(children);   // 2)
        ChildrenMethods.MaxFamilyIncomeChild(children); // 3)
        ChildrenMethods.SwapMinMaxAge(children);    // 4)

        Console.ReadKey();
    }
}