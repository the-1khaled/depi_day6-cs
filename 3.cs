using System;

struct Employee
{
    private int empId;
    private string name;

    public Employee(int id, string name, double salary)
    {
        this.empId = id;
        this.name = name;
        this.salary = salary;
    }

    public int EmpId
    {
        get { return empId; }
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
            name = newName;
        else
            Console.WriteLine("Invalid name.");
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
                salary = value;
            else
                Console.WriteLine("Salary cannot be negative.");
        }
    }

    public override string ToString()
    {
        return $"ID: {empId}, Name: {name}, Salary: {salary}";
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee(1, "Khaled", 5000);

        Console.WriteLine(emp);

        // Access using getter
        Console.WriteLine("Name: " + emp.GetName());

        // Modify using setter method
        emp.SetName("Ahmed");

        // Modify salary using property
        emp.Salary = 7000;

        // Try invalid salary
        emp.Salary = -1000;

        Console.WriteLine("After Updates:");
        Console.WriteLine(emp);
    }
}
