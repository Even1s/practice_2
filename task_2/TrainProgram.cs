namespace task_2;
internal static class TrainProgram
{
    public static void Run()
    {
        var train = new Train();
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
                    Edit(train);
                    continue;
                case "P":
                    Console.Clear();
                    Print(train);
                    continue;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
    private static void Edit(Train train)
    {
        while (true)
        {
            Console.WriteLine("Properties:");
            Console.WriteLine("[D] - Destination");
            Console.WriteLine("[N] - Train Number");
            Console.WriteLine("[T] - Departure Time");
            Console.WriteLine("[Q] - Exit");
            string? property = Console.ReadLine();
            switch (property)
            {
                case "D":
                    Console.Clear();
                    Console.Write("Write Destination: ");
                    train.Destination = Console.ReadLine() ?? string.Empty;
                    Console.Clear();
                    break;
                case "N":
                    Console.Clear();
                    Console.Write("Write Train Number: ");
                    train.TrainNumber = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Clear();
                    break;
                case "T":
                    Console.Clear();
                    Console.Write("Write Departure Date (dd.mm.yyyy): ");
                    int[]? date = Console.ReadLine()?.Split('.').ToArray().Select(int.Parse).ToArray();
                    Console.Write("Write Departure Time (hh:mm): ");
                    int[]? time = Console.ReadLine()?.Split(':').ToArray().Select(int.Parse).ToArray();
                    train.SetDeparture(date[0], date[1], date[2], time[0], time[1]);
                    Console.Clear();
                    break;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }

    static void Print(Train train)
    {
        while (true)
        {
            Console.WriteLine("Properties:");
            Console.WriteLine("[D] - Destination");
            Console.WriteLine("[N] - Train Number");
            Console.WriteLine("[T] - Departure Time");
            Console.WriteLine("[Q] - Exit");
            string? property = Console.ReadLine();
            switch (property)
            {
                case "D":
                    Console.Clear();
                    Console.WriteLine($"Destination: {train.Destination}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine($"Train Number: {train.TrainNumber}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "T":
                    Console.Clear();
                    Console.WriteLine($"Departure Time: {train.DepartureTime}");
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
}
