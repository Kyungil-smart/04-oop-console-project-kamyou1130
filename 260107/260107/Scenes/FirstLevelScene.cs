using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FirstLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
    
    /*
    private Timer timeCheck;
    private int _timeStart = 5000;
    private int _timeInterval = 5000;
    */

    public FirstLevelScene(PlayerCharacter player)
    {
        _player = player;
        point = new Point(player);
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        // timeCheck = new Timer(Timercallback, null, _timeStart, _timeInterval);
        quizList.AddQuiz("erqeqw");
        quizList.AddQuiz("qqewrq");
        quizList.AddQuiz("wqqwwq");
        quizList.AddQuiz("eqreqw");
        quizList.AddQuiz("rqrweq");
    }
    
    public void Timercallback(object? state)
    {
        Console.WriteLine("Timer callback");
    }
    
    public override void Enter()
    {
        GameManager.OnGame = true;
        quizList.start = true;
    }

    public override void Update()
    {

        result = quizList.GuessAnswer();
        point.PointProcess(result);
    }

    public override void Render()
    {
        _player.Render();
        point.PointRender();
        point.ComboRender();
        quizList.QuizPrint();
        quizList.PrintResult(result);
    }

    public override void Exit()
    {
        GameManager.OnGame = false;
    }



   



    
}