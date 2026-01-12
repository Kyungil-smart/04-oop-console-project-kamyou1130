using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FirstLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    private List<string> _quizList = new List<string>(30);
    private int _currentIndex;

    public string answer;
    private bool result;
    private bool start;
    
    /*
    private Timer timeCheck;
    private int _timeStart = 5000;
    private int _timeInterval = 5000;
    */

    public FirstLevelScene(PlayerCharacter player)
    {
        _player = player;
        Init();
    }
    
    public void Init()
    {
        // timeCheck = new Timer(Timercallback, null, _timeStart, _timeInterval);
        _quizList.Add("qqewrq");
        _quizList.Add("erqeqw");
        _quizList.Add("wqqwwq");
        _quizList.Add("eqreqw");
        _quizList.Add("rqrweq");
        point = new Point();
    }
    
    public void Timercallback(object? state)
    {
        Console.WriteLine("Timer callback");
    }
    
    public override void Enter()
    {
        GameManager.OnGame = true;
        start = true;
        _currentIndex = 0;
    }

    public override void Update()
    {
        Console.SetCursorPosition(3, 7);
        result = GuessAnswer();
        point.PointProcess(result);
    }

    public override void Render()
    {
        _player.Render();
        point.PointRender();
        QuizPrint();
        PrintResult(result);
    }

    public override void Exit()
    {
        GameManager.OnGame = false;
    }

    public void QuizPrint()
    {
        Console.SetCursorPosition(3, 5);
        Console.WriteLine(_quizList[_currentIndex]);
    }

    public bool GuessAnswer()
    {
        answer = Console.ReadLine();
        bool answerCheck = false;
        
        if (answer == _quizList[_currentIndex])
        {
            answerCheck = true;
        }
        
        _currentIndex++;
        start = false;
        
        return answerCheck;
    }

    public void PrintResult(bool result)
    {
        if (start == true) return;
        
        Console.SetCursorPosition(3, 4);
        if (result == true)
        {
            "정답!!".Print(ConsoleColor.Blue);
        }
        else
        {
            "땡!!".Print(ConsoleColor.Red);
        }
    }

    
}