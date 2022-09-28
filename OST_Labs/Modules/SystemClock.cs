namespace OST_Labs;

public class SystemClock
{
    private long _clock;
    public long Clock { get; private set; }

    public void WorkingCycle()
    {
        Clock++;
    }
    public void Clear()
    {
        Clock = 0;
    }
}