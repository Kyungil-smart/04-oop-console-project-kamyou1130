

using System.Runtime.InteropServices.Marshalling;

public class PlayerCharacter
{
    public ObservableProperty<int> Health = new ObservableProperty<int>(3);
    private string _healthGauge;
    public static bool notHealth;
    
    public bool IsActiveControl { get; private set; }

    public PlayerCharacter() => Init();

    public void Init()
    {
        IsActiveControl = true;
        Health.AddListner(SetHealthGauge);
        _healthGauge = "■■■";
        notHealth = false;
    }

    public void Update()
    {
        
    }

    public void Render()
    {
        DrawHealthGauge();
    }
    
    public void DrawHealthGauge()
    {
        Console.SetCursorPosition(0, 0);
        "하트".Print(ConsoleColor.Red);
        _healthGauge.Print(ConsoleColor.Red);
    }
    
    public void SetHealthGauge(int health)
    {
        switch (health)
        {
            case 3:
                _healthGauge = "■■■";
                break;
            case 2:
                _healthGauge = "■■□";
                break;
            case 1:
                _healthGauge = "■□□";
                break;
            case 0:
                _healthGauge = "□□□";
                notHealth = true;
                SceneManager.Change("Result");
                break;
        }
    }
}