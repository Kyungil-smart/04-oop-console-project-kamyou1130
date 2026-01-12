
public class Point
{
    public int _point;
    private int _comboValue;

    public Point()
    {
        _point = 0;
        _comboValue = 1;
    }
     
    public void PointProcess(bool result)
    {
        if (result)
        {
            _point = _point + (10 * _comboValue);
            _comboValue++;
        }
        else
        {
            _comboValue = 1;
        }
    }
    
    
    public void PointRender()
    {
        Console.SetCursorPosition(0, 1);
        Console.Write("점수 :");
        Console.WriteLine(_point);
    }
}