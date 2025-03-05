/*
Task 2:  3D Vector Class with Overloaded Operators
Task: Create a Vector3D class representing a three-dimensional vector. Implement the following:
    1) Override ToString()
        Format: "(X, Y, Z)"
    2) Overload Arithmetic Operators
        + to add vectors.
        - to subtract vectors.
        * to multiply by a scalar.
        / to divide by a scalar (handle division by zero).
    3) Overload Equality Operators (==, !=)
        Two vectors are equal if all components are equal.
    4) Implement Equals() and GetHashCode() Consistently
    5) Overload true and false Operators
        A vector is "true" if it's non-zero, otherwise "false".
    6) Overload >, <, >=, <= Based on Magnitude
*/
class Vector3D
{
    double _x;
    double _y;
    double _z;
    public double X
    {
        get => _x;
    }
    public double Y
    {
        get => _y;
    }
    public double Z
    {
        get => _z;
    }
    public Vector3D(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Vector3D v = (Vector3D)obj;
        return this == v;
    }
    public override int GetHashCode()
    {
        return this._x.GetHashCode() ^ this._y.GetHashCode() ^ this._z.GetHashCode();
    }
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1._x + v2._x, v1._y + v2._y, v1._z + v2._z);
    }
    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1._x - v2._x, v1._y - v2._y, v1._z - v2._z);
    }
    public static Vector3D operator *(Vector3D v, double scalar)
    {
        return new Vector3D(v._x * scalar, v._y * scalar, v._z * scalar);
    }
    public static Vector3D operator /(Vector3D v, double scalar)
    {
        if (scalar == 0)
        {
            Console.WriteLine("Can't divide a vector by zero.");
            Environment.Exit(0);
        }

        return new Vector3D(v._x / scalar, v._y / scalar, v._z / scalar);
    }
    public static bool operator ==(Vector3D v1, Vector3D v2)
    {
        return v1._x == v2._x && v1._y == v2._y && v1._z == v2._z;
    }
    public static bool operator !=(Vector3D v1, Vector3D v2)
    {
        return !(v1 == v2);
    }
    public static bool operator true(Vector3D v)
    {
        return Math.Sqrt(v._x * v._x + v._y * v._y + v._z * v._z) != 0;
    }
    public static bool operator false(Vector3D v)
    {
        return Math.Sqrt(v._x * v._x + v._y * v._y + v._z * v._z) == 0;
    }
    public static bool operator >(Vector3D v1, Vector3D v2)
    {
        return Math.Sqrt(v1._x * v1._x + v1._y * v1._y + v1._z * v1._z) > Math.Sqrt(v2._x * v2._x + v2._y * v2._y + v2._z * v2._z);
    }
    public static bool operator <(Vector3D v1, Vector3D v2)
    {
        return Math.Sqrt(v1._x * v1._x + v1._y * v1._y + v1._z * v1._z) < Math.Sqrt(v2._x * v2._x + v2._y * v2._y + v2._z * v2._z);
    }
    public static bool operator >=(Vector3D v1, Vector3D v2)
    {
        return Math.Sqrt(v1._x * v1._x + v1._y * v1._y + v1._z * v1._z) >= Math.Sqrt(v2._x * v2._x + v2._y * v2._y + v2._z * v2._z);
    }
    public static bool operator <=(Vector3D v1, Vector3D v2)
    {
        return Math.Sqrt(v1._x * v1._x + v1._y * v1._y + v1._z * v1._z) <= Math.Sqrt(v2._x * v2._x + v2._y * v2._y + v2._z * v2._z);
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Vector3D v1 = new Vector3D(1, 2, 3);
        Vector3D v2 = new Vector3D(3, 2, 1);

        Console.WriteLine(v1);
        Console.WriteLine(v2);

        Console.WriteLine($"Sum of vectors: {v1+v2}");
        Console.WriteLine($"Difference of vectors: {v1-v2}");
        Console.WriteLine($"Scaled vector v1: {v1*2}");
        Console.WriteLine($"Divided of vectors: {v1/2}");
        Console.WriteLine($"Vectors are equal: {v1==v2}");
        Console.WriteLine($"Vector v1 is greater than vector v2? : {v1 > v2}");
        Console.WriteLine($"Vector v1 is less than or equal to vector v2? : {v1 <= v2}");
        if (v1)
        {
            Console.WriteLine("Vector 1 is non-zero.");
        }
        else
        {
            Console.WriteLine("Vector 1 is zero.");
        }
        Console.ReadLine();
    }
}