namespace task_3;

public class Calculation
{
    private string CalculationLine { get; set; } = string.Empty;

    public string SetCalculationLine(string newValue)
    {
        CalculationLine = newValue;
        return CalculationLine;
    }

    public string SetLastSymbolCalculationLine(char lastChar)
    {
        CalculationLine += lastChar;
        return CalculationLine;
    }

    public string GetCalculationLine()
    {
        Console.WriteLine($"Line: {CalculationLine}");
        return CalculationLine;
    }
    public char GetLastSymbol()
    {
        Console.WriteLine($"Last char: {CalculationLine[^1]}");
        return CalculationLine[^1];
    }

    public string DeleteLastSymbol()
    {
        CalculationLine = CalculationLine[..^1];
        return CalculationLine;
    }
}