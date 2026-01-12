
public class Point
{
    public PlayerCharacter player;
    public int _point;
    private int _comboValue;

    public Point(PlayerCharacter player)
    {
        this.player = player;
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
            player.Health.Value--;
        }
    }
    
    
    public void PointRender()
    {
        Console.SetCursorPosition(0, 1);
        Console.Write("점수 : ");
        Console.WriteLine(_point);
    }
    
    public void ComboRender()
    {
        Console.SetCursorPosition(0, 2);
        Console.Write("콤보 : ");
        Console.WriteLine(_comboValue - 1);
    }
}