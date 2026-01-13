
public class ThirdLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
  

    public ThirdLevelScene(PlayerCharacter player, Point point)
    {
        _player = player;
        this.point = point;
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        quizList.AddQuiz("dwxcde");
        quizList.AddQuiz("wzsxca");
        quizList.AddQuiz("xczqwe");
        quizList.AddQuiz("fssqez");
        quizList.AddQuiz("xfqese");
        quizList.AddQuiz("evsaeq");
        quizList.AddQuiz("afsqes");
        quizList.AddQuiz("eeewzx");
        quizList.AddQuiz("ffsaeq");
        quizList.AddQuiz("asqsex");
        quizList.AddQuiz("xafsdq");
        quizList.AddQuiz("zaseqe");
        quizList.AddQuiz("cqeqqe");
        quizList.AddQuiz("racswd");
        quizList.AddQuiz("dqcars");
        quizList.AddQuiz("qfaqwe");
        quizList.AddQuiz("zzxdf");
        quizList.AddQuiz("vrwewe");
        quizList.AddQuiz("vssswd");
        quizList.AddQuiz("dweqad");

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