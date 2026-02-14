using System;

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Default constructor (automatically sets X and Y to 0)
    public Point()
    {
        X = 0;
        Y = 0;
    }

    // Parameterized constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Override ToString()
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Point p1 = new Point();        // Default
        Point p2 = new Point(5, 10);   // Parameterized

        Console.WriteLine(p1); // (0, 0)
        Console.WriteLine(p2); // (5, 10)
    }
}
