namespace OST_Labs;

public class Process : IComparable
{
    private long _id;
    private string _name;
    private long _workTime;
    private Random rnd;

    private long BurstTime { get; set; }
    internal ProcessStatus ProcessStatus { get; set; }
    internal long AddressSpace { get; }
    
    public Process(long pId, long pAddressSpace)
    {
        _id = pId;
        AddressSpace = pAddressSpace;
        ProcessStatus = ProcessStatus.Ready;
        _name = "Process " + pId;
        rnd = new Random();
    }
    public void IncreaseWorkTime()
    {
        if (_workTime < BurstTime)
        {
            _workTime++;
        }
        else
        {
            if (ProcessStatus == ProcessStatus.Running)
            {
                ProcessStatus = rnd.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
            }
            else
            {
                ProcessStatus = ProcessStatus.Ready;
            }
        }
    }
    
    public void ResetWorkTime()
    {
        _workTime = 0;
    }

    public override string ToString()
    {
        return "Process ID: " + _id +
               "; Process Name: " + _name +
               "; Process Status: " + ProcessStatus +
               "; Process Address Space: " + AddressSpace +
               "; Process Burst Time: " + BurstTime + ";";
    }
    
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Process otherProcess = obj as Process;
        if (otherProcess != null)
        {
            if(BurstTime < otherProcess.BurstTime)
                return -1;
            return BurstTime < otherProcess.BurstTime ? 1 : 0;
        }
        throw new ArgumentException("Object is not a Process");
    }

}

public enum ProcessStatus
{
    Ready,
    Running,
    Waiting,
    Terminated
}