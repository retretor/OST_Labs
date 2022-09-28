using System.Diagnostics.Contracts;

namespace OST_Labs;

public class Resourse
{
    private Process? _activeProcess;
    internal Process ActiveProcess { get; set; }
    
    public void WorkingCycle()
    {
        if(!IsFree())
        {
            _activeProcess.IncreaseWorkTime();
        }
    }
    [Pure]
    public bool IsFree()
    {
        return _activeProcess == null;
    }
    public void Clear()
    {
        _activeProcess = null;
    }

}