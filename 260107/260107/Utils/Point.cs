
public class Point
{
    public PlayerCharacter player;
    public int _point;
    private int _comboValue;
    public int MaxCombo;

    public Point(PlayerCharacter player)
    {
        this.player = player;
        _point = 0;
        _comboValue = 0;
        MaxCombo = 0;
    }
     
    public void PointProcess(bool result)
    {
        if (result)
        {
            _point = _point + (10 * (_comboValue + 1));
            _comboValue++;
            if (MaxCombo < _comboValue)
            {
                MaxCombo = _comboValue;
            }
        }
        else
        {
            _comboValue = 0;
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
        Console.SetCursorPosition(3, 3);
        Console.WriteLine($"{_comboValue} COMBO");
    }
    
    public void PointReset()
    {
        _point = 0;
        _comboValue = 0;
        MaxCombo = 0;
        player.Health.Value = 3;
    }
}