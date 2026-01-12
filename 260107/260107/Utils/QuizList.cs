

public class QuizList
{
    private List<string> _quizList;
    private int _currentIndex;
    
    public string answer;
    public bool start;

    public QuizList()
    {
        _quizList = new List<string>(30);
        _currentIndex = 0;
    }
    
    public void AddQuiz(string quiz)
    {
        _quizList.Add(quiz);
    }
    
    public void QuizPrint()
    {
        Console.SetCursorPosition(3, 5);
        Console.WriteLine(_quizList[_currentIndex]);
    }
    
    public bool GuessAnswer()
    {
        Console.SetCursorPosition(3, 7);
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