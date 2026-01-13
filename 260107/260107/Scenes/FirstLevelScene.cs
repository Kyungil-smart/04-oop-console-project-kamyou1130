
public class FirstLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
  

    public FirstLevelScene(PlayerCharacter player, Point point)
    {
        _player = player;
        this.point = point;
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        quizList.AddQuiz("erqeqw");
        quizList.AddQuiz("qqewrq");
        quizList.AddQuiz("wqqwwq");
        quizList.AddQuiz("eqreqw");
        quizList.AddQuiz("eqwrwe");
        quizList.AddQuiz("wweqre");
        quizList.AddQuiz("rweqwe");
        quizList.AddQuiz("rrqweq");
        quizList.AddQuiz("erwweq");
        quizList.AddQuiz("weeeqr");
        quizList.AddQuiz("eeeeeq");
        quizList.AddQuiz("eqwrwe");
        quizList.AddQuiz("qrrrwe");
        quizList.AddQuiz("wereqr");
        quizList.AddQuiz("rrqqwe");
        quizList.AddQuiz("rqrrrw");
        quizList.AddQuiz("werrwe");
        quizList.AddQuiz("qrwewe");
        quizList.AddQuiz("wwewwe");
        quizList.AddQuiz("eqqweq");

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