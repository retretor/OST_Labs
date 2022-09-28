namespace OST_Labs;

public class CPUScheduler
{
    private Resourse _resource;
    private IQueryable<Process> _queue;
    
    public CPUScheduler(Resourse resource, IQueryable<Process> queue)
    {
        _resource = resource;
        _queue = queue;
    }

    public IQueryable<Process> Session()
    {
        Process process = _queue.First();
        process.ProcessStatus = ProcessStatus.Running;
        _resource.ActiveProcess = process;
        return _queue.Take(1);
    }
}