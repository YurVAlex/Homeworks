namespace Homework06;

public abstract class EmployeeBase (string name = "Unknown", 
                                    string position = "Not assigned")
{
    public string Name { get; set; } = name;    // Output checks - listnen task!!!

    public string Position { get; set; } = position;    // make it enum?

    public abstract void GetDetails(); 
}
