namespace task_3;

public static class CalculationProgram
{
    public static void Run()
    {
        var line = new Calculation();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Properties:");
            Console.WriteLine("[S] - Set");
            Console.WriteLine("[L] - Set last");
            Console.WriteLine("[G] - Get");
            Console.WriteLine("[K] - Get last");
            Console.WriteLine("[D] - Delete last");
            Console.WriteLine("[Q] - Exit");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "S":
                    Console.Clear();
                    Console.Write("Write new Line: ");
                    line.SetCalculationLine(Console.ReadLine() ?? string.Empty);
                    Console.Clear();
                    continue;
                case "L":
                    Console.Clear();
                    Console.Write("Write new Char: ");
                    line.SetLastSymbolCalculationLine(Console.ReadLine()![0]);
                    Console.Clear();
                    continue;
                case "G":
                    Console.Clear();
                    line.GetCalculationLine();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "K":
                    Console.Clear();
                    line.GetLastSymbol();
                    Console.Write("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "D":
                    line.DeleteLastSymbol();
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