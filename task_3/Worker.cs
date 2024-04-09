namespace task_3;

public class Worker(string name, string surname, int rate, int days)
{
    private string Name { get; } = name;
    private string Surname { get; } = surname;
    private int Rate { get; } = rate;
    private int Days { get; } = days;

    public int GetSalary()
    {
        Console.WriteLine($"Salary: {Rate * Days}");
        return Rate * Days;
    }

    public string GetName()
    {
        Console.WriteLine($"Name: {Name}");
        return Name;
    }
    public string GetSurname()
    {
        Console.WriteLine($"Surname: {Surname}");
        return Surname;
    }
    public int GetRate()
    {
        Console.WriteLine($"Rate: {Rate}");
        return Rate;
    }
    public int GetDays()
    {
        Console.WriteLine($"Days: {Days}");
        return Days;
    }
}