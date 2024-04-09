namespace task_3;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Programs:");
            Console.WriteLine("[W] - Worker");
            Console.WriteLine("[C] - Calculation");
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "C":
                    Console.Clear();
                    CalculationProgram.Run();
                    continue;
                case "W":
                    Console.Clear();
                    WorkerProgram.Run();
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