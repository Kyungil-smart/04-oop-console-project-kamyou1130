
public class ExplainScene : Scene
{
    public override void Enter()
    {
        
    }

    public override void Update()
    {
        if (InputManager.GetKey(ConsoleKey.Enter))
        {
            SceneManager.ChangePrevScene();
        }
    }

    public override void Render()
    {
        Console.SetCursorPosition(3, 1);
        "**순발력 타자 게임 설명**".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3, 3);
        "순발력 타자 게임은 총 5단계로".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3, 4);
        "1단계 쉬움부터 5단계 어려움까지".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3,5);
        "구성되어 있습니다!".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3,6);
        "콘솔에 출력되는 영어를 시간안에".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3,7);
        "타자를 치고 엔터키를 누르면 성공!".Print(ConsoleColor.Yellow);
        Console.SetCursorPosition(3, 8);
        "연속으로 성공하여 콤보를 쌓을 수록 높은 점수!".Print(ConsoleColor.Red);
        Console.SetCursorPosition(3, 10);
        "!설명창을 닫고 싶으면 엔터키를 눌러주세요!".Print(ConsoleColor.Yellow);
        
    }

    public override void Exit()
    {
        
    }
}