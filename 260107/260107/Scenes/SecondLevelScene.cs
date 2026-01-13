

public class SecondLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
  

    public SecondLevelScene(PlayerCharacter player, Point point)
    {
        _player = player;
        this.point = point;
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        quizList.AddQuiz("dwaseq");
        quizList.AddQuiz("qesdae");
        quizList.AddQuiz("awqesd");
        quizList.AddQuiz("rqseas");
        quizList.AddQuiz("fasqer");
        quizList.AddQuiz("erqrsa");
        quizList.AddQuiz("asdqer");
        quizList.AddQuiz("eewsad");
        quizList.AddQuiz("ffsdae");
        quizList.AddQuiz("aseeqr");
        quizList.AddQuiz("ressdq");
        quizList.AddQuiz("faseqe");
        quizList.AddQuiz("sqsqqe");
        quizList.AddQuiz("rasewd");
        quizList.AddQuiz("dqwers");
        quizList.AddQuiz("qwerwe");
        quizList.AddQuiz("esewdf");
        quizList.AddQuiz("qrwewe");
        quizList.AddQuiz("sssswd");
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
        result = quizList.GuessAnswer();
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