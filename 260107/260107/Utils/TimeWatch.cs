
using System.Diagnostics;

public class TimeWatch
{
    private double _prevTime;
    private double _currentTime;
    
    // 프레임 사이의 시간(핵심)
    public static double DeltaTime { get; private set; }

    public Stopwatch stopwatch;

    public TimeWatch() => Init();

    public void Init()
    {
        stopwatch = Stopwatch.StartNew();
        _currentTime = stopwatch.Elapsed.TotalSeconds;
        _prevTime = _currentTime;
        DeltaTime = 0.0;
    }

    public void Tick()
    {
        _prevTime = _currentTime;
        _currentTime = stopwatch.Elapsed.TotalSeconds;
        
        DeltaTime = _currentTime - _prevTime;
    }
}