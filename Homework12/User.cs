using System.Text.RegularExpressions;

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

    public bool IsValid()
    {
        return IsValidName(Name) && IsValidEmail(Email) && IsValidAge(Age);
    }

    public static bool IsValidName(string name)
    {
        var regex = new Regex(@"^[A-Za-z\s'-]{2,}$");
        
        return regex.IsMatch(name);
    }

    public static bool IsValidAge(int age)
    {
        return age >= 0 && age <= MaxAge;
    }

    public static bool IsValidEmail(string email)
    {
        var regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

        return regex.IsMatch(email);
    }
}