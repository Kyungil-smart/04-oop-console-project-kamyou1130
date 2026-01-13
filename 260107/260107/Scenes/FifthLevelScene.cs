
public class FifthLevelScene : Scene
{
    public PlayerCharacter _player;
    public Point point;
    public QuizList quizList;

    private bool result;
  

    public FifthLevelScene(PlayerCharacter player, Point point)
    {
        _player = player;
        this.point = point;
        Init();
    }
    
    public void Init()
    {
        quizList = new QuizList();
        quizList.AddQuiz("hfjlkw");
        quizList.AddQuiz("xsauqe");
        quizList.AddQuiz("rawirq");
        quizList.AddQuiz("fhgebe");
        quizList.AddQuiz("epqwje");
        quizList.AddQuiz("fwpeob");
        quizList.AddQuiz("benemr");
        quizList.AddQuiz("aesnbo");
        quizList.AddQuiz("klneio");
        quizList.AddQuiz("coenmn");
        quizList.AddQuiz("zooppm");
        quizList.AddQuiz("weqldw");
        quizList.AddQuiz("dsfjak");
        quizList.AddQuiz("nkqqey");
        quizList.AddQuiz("bggyeu");
        quizList.AddQuiz("gnnnnd");
        quizList.AddQuiz("xkerfs");
        quizList.AddQuiz("ouunue");
        quizList.AddQuiz("qeemer");
        quizList.AddQuiz("finish");

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