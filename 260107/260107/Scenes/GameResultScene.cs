

public class GameResultScene : Scene
{
    private MenuList _selectList = new MenuList();
    private Point _point;

    public GameResultScene(Point point)
    {
        _point = point;
        Init();
    }

    public void Init()
    {
        _selectList.Add("난이도 선택", ReStart);
        _selectList.Add("종료", TitleScene.GameQuit);
    }

    public override void Enter()
    {
        
    }

    public override void Update()
    {
        if (InputManager.GetKey(ConsoleKey.UpArrow))
        {
            _selectList.SelectUp();
        } 
        
        if (InputManager.GetKey(ConsoleKey.DownArrow))
        {
            _selectList.SelectDown();
        }

        if (InputManager.GetKey(ConsoleKey.Enter))
        {
            _selectList.Select();
        }
    }

    public override void Exit()
    {
        
    }

    public override void Render()
    {
        Console.SetCursorPosition(2, 2);
        Console.WriteLine($"최종 점수 : {_point._point}");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine($"최대 콤보 : {_point.MaxCombo}");
        
        _selectList.Render(2, 6);
    }
    
    public void ReStart()
    {
        SceneManager.Change("Select");
        _point.PointReset();
    }
}