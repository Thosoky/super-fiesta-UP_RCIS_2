namespace pr2._2;

public class Counter
{
    public int CurrentStatus { get; set; }

    public Counter(int currentStatus)
    {
        CurrentStatus = currentStatus;
    }
    public Counter()
    {
        CurrentStatus = -5;
    }

    public int Increase()
    {
        CurrentStatus = ++CurrentStatus;
        return CurrentStatus;
    }

    public int Decrease()
    {
        CurrentStatus = --CurrentStatus;
        return CurrentStatus;
    }
}