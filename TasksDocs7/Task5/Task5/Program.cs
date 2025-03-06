/* 
Task 5:  Multi - Parameter Indexer for 3D Space
Task: Create a Grid3D class that :
    1) Stores values in a 3D space (x, y, z coordinates).
    2) Uses an indexer with three integer parameters.
    3) Throws an error if any index is out of bounds.
*/

class Grid3D
{
    int[]? xyz = new int[3];
    public int this[int x, int y, int z]
    {
        get
        {
            return (x == xyz[0]) && (y == xyz[1]) && (z == xyz[2]) ? 1 : -1;
        }
    }
    public Grid3D(int x, int y, int z)
    {
        xyz[0] = x;
        xyz[1] = y;
        xyz[2] = z;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Grid3D coordinate = new Grid3D(1,2,3);
        Console.WriteLine(coordinate[2,2,3]);
        Console.ReadLine();
    }
}