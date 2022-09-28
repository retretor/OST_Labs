namespace OST_Labs;

public class Memory
{
    public long Size { get; private set; }
    private long _occupiedSize;
    private long OccupiedSize { get; set; }
    public long FreeSize { get; private set; }
    
    public void Save(long size)
    {
        Size = size;
        _occupiedSize = 0;
    }
    public void Clear()
    {
        Size = 0;
        _occupiedSize = 0;
    }
    public bool Allocate(Process process)
    {
        if (process.AddressSpace > FreeSize)
        {
            return false;
        }
        _occupiedSize += process.AddressSpace;
        return true;
    }

    public void Free(Process process)
    {
        _occupiedSize -= process.AddressSpace;
    }
}