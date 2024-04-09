namespace task_2;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Programs:");
            Console.WriteLine("[S] - Student");
            Console.WriteLine("[T] - Train");
            Console.WriteLine("[N] - Numbers");
            Console.WriteLine("[C] - Counter");
            Console.WriteLine("[D] - Destructible");
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "S":
                    Console.Clear();
                    StudentProgram.Run();
                    continue;
                case "T":
                    Console.Clear();
                    TrainProgram.Run();
                    continue;
                case "N":
                    Console.Clear();
                    NumbersProgram.Run();
                    continue;
                case "C":
                    Console.Clear();
                    CounterProgram.Run();
                    continue;
                case "D":
                    Console.Clear();
                    DestructibleProgram.Run();
                    continue;
                case "Q":
                    Console.Clear();
                    Console.WriteLine("Finish");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }

            break;
        }
    }
}