namespace Homework06;

public static class EmployeeRegistry
{
    // Static list to store all employees
    private static List<EmployeeBase> _employees = [];

    public static void AddEmployee(EmployeeBase employee)
    {
        _employees.Add(employee);
    }

    public static void SortEmployees()
    {
        _employees = _employees.OrderBy(_ => _.Name).ToList();
    }

    public static void ListAllEmployees()
    {
        if (_employees.Count == 0)
        {
            Console.Write("The list of employees is empty.\n");
        }
        else
        {
            Console.Write($"\nList of employees:\n");
            _employees.ForEach(_ => _.GetDetails());
        }
    }

    // Finds and displays an employee by name (case-insensitive)
    public static void FindEmployee(string name)
    {
        var employee = _employees.Find(_ =>
            _.Name.Equals(name.Trim(), StringComparison.OrdinalIgnoreCase));

        if (employee != null)
        {
            Console.Write($"\nThe employee has been found.\n");
            employee.GetDetails();
        }
        else
        {
            Console.Write($"\nEmployee with name \"{name}\" not found.\n");
        }
    }
}
