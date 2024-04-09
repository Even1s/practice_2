namespace task_2;

internal static class CounterProgram
{
    public static void Run()
    {
        Console.Write("Write init values: ");
        string? init = Console.ReadLine();
        Random rnd = new Random();
        var counter = new Counter(init != "" ? int.Parse(init) : rnd.Next(100));
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("[U] - Up");
            Console.WriteLine("[D] - Down");
            Console.WriteLine("[P] - Print");
            Console.WriteLine("[Q] - Exit");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "U":
                    Console.Clear();
                    counter.UpCounter();
                    continue;
                case "D":
                    Console.Clear();
                    counter.DownCounter();
                    continue;
                case "P":
                    Console.Clear();
                    Console.WriteLine($"Counter: {counter.CounterValue}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
}