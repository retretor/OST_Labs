namespace OST_Labs;

public class MemoryMamager
{
    private Memory _memory;

    public void Save(long size)
    {
        // initialize memory
        _memory = new Memory();
        _memory.Save(size);
    }
    public Memory Allocate(Process process)
    {
        if (_memory.Allocate(process))
        {
            return _memory;
        }
        else
        {
            return null;
        }
    }
    public void Free(Process process)
    {
        _memory.Free(process);
    }

}