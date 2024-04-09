namespace task_3;

public static class WorkerProgram
{
    public static void Run()
    {
        Console.Write("Write Name: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.Write("Write Surname: ");
        string surname = Console.ReadLine() ?? string.Empty;
        Console.Write("Write Rate: ");
        int rate = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Write Days: ");
        int days = int.Parse(Console.ReadLine() ?? "0");
        var worker = new Worker(name, surname, rate, days);
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Properties:");
            Console.WriteLine("[N] - Name");
            Console.WriteLine("[S] - Surname");
            Console.WriteLine("[R] - Rate");
            Console.WriteLine("[D] - Days");
            Console.WriteLine("[P] - Salary");
            Console.WriteLine("[Q] - Exit");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "N":
                    Console.Clear();
                    worker.GetName();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "S":
                    Console.Clear();
                    worker.GetSurname();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "R":
                    Console.Clear();
                    worker.GetRate();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "D":
                    Console.Clear();
                    worker.GetDays();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "P":
                    Console.Clear();
                    worker.GetSalary();
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