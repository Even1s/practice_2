namespace task_2;

public class Destructible
{
    public int Counter { get; }
    public string Name { get; }

    public Destructible(int counter, string name)
    {
        Counter = counter;
        Name = name;
    }

    public Destructible()
    {
        Random rnd = new Random();
        Counter = rnd.Next(50);
        Name = "Dima";
    }

    ~Destructible()
    {
        Console.WriteLine($"Counter: {Counter}, Name: {Name} id Deleted");
    }
}