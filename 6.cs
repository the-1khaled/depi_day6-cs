struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }
}
using System;

class Program
{
    static void ModifyPoint(Point p)
    {
        p.X = 100;
        p.Y = 100;
    }

    static void ModifyEmployee(Employee e)
    {
        e.Name = "Modified";
    }

    static void Main()
    {
        Point point = new Point(1, 2);
        Employee emp = new Employee("Khaled");

        ModifyPoint(point);
        ModifyEmployee(emp);

        Console.WriteLine($"Point: {point.X}, {point.Y}");
        Console.WriteLine($"Employee: {emp.Name}");
    }
}
