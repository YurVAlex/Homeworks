using System.Text.RegularExpressions;

namespace Homework12;

public static class Validator
{
    private static Regex _nameRegex = new Regex(@"^[A-Za-z\s'-]{2,}$");
    private static Regex _emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

    public static bool IsValid(User user)
    {
        return IsValidName(user.Name) && IsValidEmail(user.Email) && IsValidAge(user.Age);
    }

    public static bool IsValidName(string name) => _nameRegex.IsMatch(name);

    public static bool IsValidAge(int age) => (age >= 0 && age <= User.MaxAge);

    public static bool IsValidEmail(string email) => _emailRegex.IsMatch(email);
}