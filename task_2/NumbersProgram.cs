namespace task_2;

internal static class NumbersProgram
{
    public static void Run()
    {
        var numbers = new Numbers();
        while (true)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("[E] - Edit");
            Console.WriteLine("[P] - Print");
            Console.WriteLine("[Q] - Exit");
            string? command = Console.ReadLine();
            switch (command)
            {
                case "E":
                    Console.Clear();
                    Edit(numbers);
                    continue;
                case "P":
                    Console.Clear();
                    Print(numbers);
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
    private static void Edit(Numbers numbers)
    {
        while (true)
        {
            Console.WriteLine("Numbers:");
            Console.WriteLine("[F] - First");
            Console.WriteLine("[S] - Second");
            Console.WriteLine("[Q] - Exit");
            string? property = Console.ReadLine();
            switch (property)
            {
                case "F":
                    Console.Clear();
                    Console.Write("Write number: ");
                    numbers.SetFirst(int.Parse(Console.ReadLine() ?? string.Empty));
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    Console.Write("Write number: ");
                    numbers.SetSecond(int.Parse(Console.ReadLine() ?? string.Empty));
                    Console.Clear();
                    break;
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

    static void Print(Numbers numbers)
    {
        while (true)
        {
            Console.WriteLine("Print:");
            Console.WriteLine("[F] - First");
            Console.WriteLine("[S] - Second");
            Console.WriteLine("[P] - Sum");
            Console.WriteLine("[M] - Maximal");
            Console.WriteLine("[Q] - Exit");
            string? property = Console.ReadLine();
            switch (property)
            {
                case "F":
                    Console.Clear();
                    numbers.PrintFirst();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    numbers.PrintSecond();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "P":
                    Console.Clear();
                    Console.WriteLine($"Sum: {numbers.Sum()}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "M":
                    Console.Clear();
                    Console.WriteLine($"Maximal: {numbers.Maximal()}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
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