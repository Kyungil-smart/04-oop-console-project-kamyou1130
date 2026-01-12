
public class LevelSelectScene : Scene
{
    private MenuList _levelList;

    public LevelSelectScene()
    {
        Init();
    }

    public void Init()
    {
        _levelList = new MenuList();
        _levelList.Add("1단계 매우 쉬움", FirstLevelChange);
        _levelList.Add("2단계 쉬움", SecondLevelChange);
        _levelList.Add("3단계 보통", ThirdLevelChange);
        _levelList.Add("4단계 어려움", FourthLevelChange);
        _levelList.Add("5단계 매우 어려움", FifthLevelChange);
    }

    public void FirstLevelChange()
    {
        SceneManager.Change("First");
    }

    public void SecondLevelChange()
    {
        SceneManager.Change("Second");
    }

    public void ThirdLevelChange()
    {
        SceneManager.Change("Third");
    }

    public void FourthLevelChange()
    {
        SceneManager.Change("Fourth");
    }

    public void FifthLevelChange()
    {
        SceneManager.Change("Fifth");
    }
    
    public override void Enter()
    {
        _levelList.Reset();
        Debug.Log("난이도 선택 씬 진입");
    }

    public override void Update()
    {
        if (InputManager.GetKey(ConsoleKey.UpArrow))
        {
            _levelList.SelectUp();
        } 
        
        if (InputManager.GetKey(ConsoleKey.DownArrow))
        {
            _levelList.SelectDown();
        }

        if (InputManager.GetKey(ConsoleKey.Enter))
        {
            _levelList.Select();
        }
    }

    public override void Render()
    {
        Console.SetCursorPosition(4, 1);
        "난이도를 선택해주세요!".Print(ConsoleColor.White);
        _levelList.Render(5, 3);
    }

    public override void Exit()
    {
        
    }
    
}