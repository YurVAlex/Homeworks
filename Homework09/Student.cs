namespace Homework09;

public class Student
{
    private string _name;
    private int _age;
    private double _averageMark;

    public Student()
    {
        _name = "Unknown";
        _age = 0;
        _averageMark = 0;
    }

    public Student(string name, int age, double averageMark)
    {
        Name = name;
        Age = age;
        AverageMark = averageMark;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            { 
                _name = value; 
            }
            else
            { 
                _name = "Unknown"; 
            }
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value >= 0 && value <= 150)
            { 
                _age = value; 
            }
            else
            { 
                _age = 0; 
            }
        }
    }

    public double AverageMark
    {
        get => _averageMark;
        set
        {
            if (value >= 0.0 && value <= 10)
            {
                _averageMark = value;
            }
            else
            {
                _averageMark = 0;
            }
        }
    }

    public override string ToString()
    {
        return $"Name: {_name}, Age: {_age}, Average Mark: {_averageMark:F2}";
    }
}
