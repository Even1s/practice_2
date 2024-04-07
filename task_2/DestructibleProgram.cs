namespace task_2;

public static class DestructibleProgram
{
    public static void Run()
    {
        Console.Write("Write number: ");
        int count = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Write name: ");
        string name = Console.ReadLine() ?? string.Empty;
        Destructible destructible = new Destructible(count, name);
        Console.Write("Press Enter");
        Console.ReadLine();
        Console.Clear();
    }
}