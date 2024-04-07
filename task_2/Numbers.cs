namespace task_2;

public class Numbers
{
    private int First { get; set; }
    private int Second { get; set; }

    public void PrintFirst()
    {
        Console.WriteLine($"First: {First}");
    }
    public void PrintSecond()
    {
        Console.WriteLine($"Second: {Second}");
    }

    public int SetFirst(int value)
    {
        First = value;
        return First;
    }
    public int SetSecond(int value)
    {
        Second = value;
        return Second;
    }

    public int Sum()
    {
        return First + Second;
    }

    public int Maximal()
    {
        return int.Max(First, Second);
    }
}