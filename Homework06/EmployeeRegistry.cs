namespace Homework06;

public static class EmployeeRegistry
{
    private static List<EmployeeBase> _employees = [];

    public static void AddEmployee(EmployeeBase employee)
    {
        _employees.Add(employee);
    }

    public static void ListAllEmployees()
    {
        if (_employees.Count == 0)
        {
            Console.Write("The list of employees is empty.\n");
        }
        else 
        {
            Console.Write($"List of employees:\n");
            _employees.Sort();
            _employees.ForEach(employe => employe.GetDetails());
        }
    }

    public static void FindEmployee(string name)
    {
        var employee = _employees.Find(_ => 
        _.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (employee != null)
        {
            Console.Write($"The employee has been found.\n");
            employee.GetDetails();
        }
        else
        {
            Console.Write($"Employee with name \"{name}\" not found.\n");
        }
    }
}
