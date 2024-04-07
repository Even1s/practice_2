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
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command)
            {
                case "S":
                    Console.Clear();
                    StudentProgram.Run();
                    continue;
                case "T":
                    Console.Clear();
                    TrainProgram.Run();
                    continue;
                case "Q":
                    Console.WriteLine("Finish");
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