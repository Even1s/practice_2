namespace task_4;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Programs:");
            Console.WriteLine("[D] - Decode");
            Console.WriteLine("[Q] - Finish");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "D":
                    Console.Clear();
                    Console.Write("Write Roman number: ");
                    int result = DecodeRomanian(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine(result);
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

    private static readonly Dictionary<char, int> RomanNumbers = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    private static int DecodeRomanian(string romanian)
    {
        romanian = romanian.ToUpper();
        int total = 0, minus = 0;
        for (int i = 0; i < romanian.Length; i++)
        {
            int thisNumeral = RomanNumbers[romanian[i]] - minus;
            if (i >= romanian.Length - 1 || thisNumeral + minus >= RomanNumbers[romanian[i + 1]])
            {
                total += thisNumeral;
                minus = 0;
            }
            else minus = thisNumeral;
        }
        return total;
    }
}
