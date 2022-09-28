namespace OST_Labs;

public class DeviceScheduler
{
    private Resourse _resourse;
    private IQueryable<Process> _queue;
    
    public DeviceScheduler(Resourse resourse, IQueryable<Process> queue)
    {
        _resourse = resourse;
        _queue = queue;
    }

    private IQueryable<Process> Session()
    {
        return _queue.Where(p => p.ProcessStatus == ProcessStatus.Waiting);
    }
}