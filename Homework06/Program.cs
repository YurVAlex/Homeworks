namespace Homework06;

public class Program
{
    static void Main(string[] args)
    {
        TestMessage("Worker with no skills");
        var worker1 = new Worker("Cringer", "Developer");
        worker1.GetDetails();
        worker1.RemoveSkill("C#"); // Removing non-existing skill
        worker1.AddSkill("C++");

        TestMessage("Worker with skills");
        var worker2 = new Worker("Alice May", "QA", "Selenium", "Python");
        worker2.GetDetails();
        worker2.AddSkill("C#");
        worker2.RemoveSkill("Selenium");
        worker2.GetDetails();

        TestMessage("Manager with no projects and 0 experience");
        var manager1 = new Manager("Alex", "Team Lead");
        manager1.GetDetails();

        TestMessage("Manager with projects and experience");
        var manager2 = new Manager("Uncle Bob", "Project Manager", 55);
        manager2.AddProject(new Manager.Project("Alpha", "2025-12-31"));
        manager2.AddProject("Smile, 2026-01-15"); // Add via string with comma
        manager2.AddProject("Star Wars"); // Add via string without comma
        manager2.GetDetails();
        manager2.DeleteProject("Star Wars");
        manager2.GetDetails();
        manager2.DeleteProject("Nonexistent");

        TestMessage("Employee Registry");
        EmployeeRegistry.AddEmployee(worker1);
        EmployeeRegistry.AddEmployee(worker2);
        EmployeeRegistry.AddEmployee(manager1);
        EmployeeRegistry.AddEmployee(manager2);

        TestMessage("List All Employees (unsorted)");
        EmployeeRegistry.ListAllEmployees();

        TestMessage("Sort Employees and List Again");
        EmployeeRegistry.SortEmployees();
        EmployeeRegistry.ListAllEmployees();

        TestMessage("Find Employee: AlICE may");
        EmployeeRegistry.FindEmployee("AlICE may"); // Case-insensitive check

        TestMessage("Find Employee: Alex (trim check)");
        EmployeeRegistry.FindEmployee(" Alex"); // Trim check

        TestMessage("Find Employee: NotInList");
        EmployeeRegistry.FindEmployee("NotInList");

        TestMessage("Find Employee: User query");
        Console.WriteLine("\nPlease enter employee name:");
        EmployeeRegistry.FindEmployee(Console.ReadLine());
    }

    public static void TestMessage(string message)
    {
        Console.WriteLine($"\n=== TEST: {message} ===");
    }
}
