
namespace ChildrenAndParents
{
    static class ChildrenMethods
    {
        public static void PrintByParentsAge(double year, params Child[] children)
        {
            int counter = 0;
            Console.WriteLine($"\nChildren whose parents combined age does not exceed {year} years:");
            for (int i = 0; i < children.Length; ++i)
            {
                if ((children[i].Father.Age + children[i].Mother.Age) < year)
                {
                    Console.WriteLine($"Child {i}:\n Name: {children[i].Name}\n Age: {children[i].Age}");
                    ++counter;
                }
            }
            if (counter == 0)
                Console.WriteLine("No children with parents older than {year} years\n");
        }
        public static void MaxAgeFatherSalary(params Child[] children)
        {
            int index = 0;
            for (int i = 1; i < children.Length; ++i)
            {
                if (children[i].Age > children[index].Age)
                    index = i;
            }
            Console.WriteLine($"\nOldest child and his father's salary:\n Name: {children[index].Name}\n Age: {children[index].Age}\n Father's Salary: {children[index].Father.Salary} $");
        }
        public static void MaxFamilyIncomeChild(params Child[] children)
        {
            int index = 0;
            for (int i = 1; i < children.Length; ++i)
            {
                if ((children[i].Father.Salary + children[i].Mother.Salary) > (children[index].Father.Salary + children[index].Mother.Salary))
                    index = i;
            }
            Console.WriteLine($"\nChild with most family income:\n Name: {children[index].Name}\n Age: {children[index].Age}\n Family Profit: {children[index].Father.Salary + children[index].Mother.Salary} $");
        }
        public static void SwapMinMaxAge(params Child[] children)
        {
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < children.Length; ++i)
            {
                if (children[i].Age < children[minIndex].Age)
                    minIndex = i;
                if (children[i].Age > children[maxIndex].Age)
                    maxIndex = i;
            }
            Child temp = children[minIndex];
            children[minIndex] = children[maxIndex];
            children[maxIndex] = temp;
            Console.WriteLine("\nChildren after swapping the youngest and the oldest:");
            for (int i = 0; i < children.Length; ++i)
            {
                Console.WriteLine($"Child {i}:\n Name: {children[i].Name}, Age: {children[i].Age}");
            }
        }
    }
}