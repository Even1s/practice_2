namespace task_2;

public class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; private set; }

    public DateTime SetDeparture(int day, int month, int year, int hour, int minute)
    {
        DepartureTime = new DateTime(year, month, day, hour, minute, 0);
        return DepartureTime;
    }
}