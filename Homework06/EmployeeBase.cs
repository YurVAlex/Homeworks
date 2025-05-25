namespace Homework06;

public abstract class EmployeeBase(string name = "Unknown",
                                   string position = "Not assigned")
{
    public string Name { get; set; } = name;

    public string Position { get; set; } = position;

    public abstract void GetDetails();
}
