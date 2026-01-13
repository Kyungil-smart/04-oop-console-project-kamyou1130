using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class GameManager
{
    public static bool IsGameOver { get; set; }
    public static bool OnGame { get; set; }
    public const string GameName = "순발력 타자 게임";
    private PlayerCharacter _player;
    public TimeWatch time;
    private double _timeCount;
    private Point _point;

    public void Run()
    {
        Init();
        
        while (!IsGameOver)
        {
            // 렌더링
            Console.Clear();
            SceneManager.Render();
            time.Tick();
            _timeCount += TimeWatch.DeltaTime;

            if (_timeCount >= 5f)
            {
                time.stopwatch.Restart();
                continue;
            }
            
            // 키입력 받고
            if(!OnGame) InputManager.GetUserInput();

            if (InputManager.GetKey(ConsoleKey.L))
            {
                SceneManager.Change("Log");
            }

            // 데이터 처리
            SceneManager.Update();
        }
    }

    private void Init()
    {
        IsGameOver = false;
        OnGame = false;
        SceneManager.OnChangeScene += InputManager.ResetKey;
        _player = new PlayerCharacter();
        time = new TimeWatch();
        _timeCount = 0f;
        _point = new Point(_player);
        
        SceneManager.AddScene("Title", new TitleScene());
        SceneManager.AddScene("Log", new LogScene());
        SceneManager.AddScene("Explain", new ExplainScene());
        SceneManager.AddScene("Select", new LevelSelectScene());
        SceneManager.AddScene("First", new FirstLevelScene(_player, _point));
        SceneManager.AddScene("Second", new SecondLevelScene(_player, _point));
        SceneManager.AddScene("Third", new ThirdLevelScene(_player, _point));
        SceneManager.AddScene("Fourth", new FourthLevelScene(_player, _point));
        SceneManager.AddScene("Fifth", new FifthLevelScene(_player, _point));
        SceneManager.AddScene("Result", new GameResultScene(_point));
        
        SceneManager.Change("Title");
        
        Debug.Log("게임 데이터 초기화 완료");
    }
    
}