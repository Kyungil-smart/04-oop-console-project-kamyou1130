
public class FourthLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
  

    public FourthLevelScene(PlayerCharacter player, Point point)
    {
        _player = player;
        this.point = point;
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        quizList.AddQuiz("hfheku");
        quizList.AddQuiz("xufowe");
        quizList.AddQuiz("reuass");
        quizList.AddQuiz("fssqez");
        quizList.AddQuiz("epusra");
        quizList.AddQuiz("fwizxo");
        quizList.AddQuiz("reuqed");
        quizList.AddQuiz("aeqqoo");
        quizList.AddQuiz("euraxc");
        quizList.AddQuiz("cwqvtt");
        quizList.AddQuiz("zsdwey");
        quizList.AddQuiz("weqtdq");
        quizList.AddQuiz("dayeor");
        quizList.AddQuiz("prqwey");
        quizList.AddQuiz("pzxyeu");
        quizList.AddQuiz("iewsdd");
        quizList.AddQuiz("weyrfs");
        quizList.AddQuiz("sasdue");
        quizList.AddQuiz("yayqer");
        quizList.AddQuiz("uwepad");

        result = false;
    }
    
    public override void Enter()
    {
        GameManager.OnGame = true;
        quizList.start = true;
    }

    public override void Update()
    {
        result = quizList.CheckAnswer();
        point.PointProcess(result);
        quizList.GameResult();
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
        quizList.start = false;
        quizList._currentIndex = 0;
    }
}