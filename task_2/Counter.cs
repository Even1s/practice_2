namespace task_2;

public class Counter(int value = 0)
{
    public int CounterValue { get; private set; } = value;

    public int UpCounter()
    {
        CounterValue++;
        return CounterValue;
    }
    public int DownCounter()
    {
        CounterValue--;
        return CounterValue;
    }
}