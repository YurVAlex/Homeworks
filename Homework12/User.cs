namespace Homework12;

public class User (string name, int age, string email)
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;

    public int Age { get; set; } = age;
    public static int MaxAge { get; set; } = 150;

    public override string ToString()
    {
        return $"name: {Name}, age: {Age}, e-mail: {Email}";
    }
}