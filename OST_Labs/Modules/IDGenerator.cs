namespace OST_Labs;

public class IDGenerator
{
    private long _id;
    private long Id
    {
        get { return _id == long.MaxValue ? 0 : ++_id; }
    }
    
    public void Clear()
    {
        _id = 0;
    }
}