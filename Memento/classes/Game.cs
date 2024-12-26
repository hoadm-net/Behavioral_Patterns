namespace Memento.classes;

public class Game
{
    private GameHistory _history;
    private int Width { get; }
    private int Height { get; }
    private Snake Player { get; set; }
    private Food Food { get; set; }
    private bool GameOver { get; set; }
    private int Score { get; set; }
    
    const int SaveInterval = 2; // Cứ mỗi 5 điểm sẽ lưu trạng thá

    public Game(int width, int height)
    {
        Width = width;
        Height = height;
        Player = new Snake(width / 2, height / 2);
        Food = new Food(width, height);
        GameOver = false;
        Score = 0;
        
        _history = new GameHistory();
        
        Player.OnEatFood += HandleEatFood;
        Player.OnEatFood += HandleEatFoodSound;
    }

    private void HandleEatFood(object? sender, EventArgs e)
    {
        Score++;
        Player.Grow();
        Food.Generate(Player.Body);

        if (Score % SaveInterval == 0)
        {
            _history.Save(this.GetGameState());
        }
    }

    private void HandleEatFoodSound(object? sender, EventArgs e)
    {
        Console.Beep();
    }

    public void Start()
    {
        start_game:
        Console.CursorVisible = false;
        Food.Generate(Player.Body);
        while (!GameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(300);
        }
        Console.Clear();
        Console.WriteLine($"Game Over! Final Score: {Score}");
        
        GameState lastState = _history.GetLastState();
        if (lastState != null)
        {   
            Console.Write("Do you want to play again? (y/n)");
            string user_input = Console.ReadLine();
            if (user_input.Trim().ToLower() == "y")
            {
                this.RestoreState(lastState);
                GameOver = false;
                Console.Clear();
                goto start_game;
            }
        }
    }

    private void Draw()
    {
        Console.Clear();
        Board.DrawBorder(Width, Height);
        Player.Draw();
        Food.Draw();
        Console.SetCursorPosition(0, Height);
        Console.WriteLine($"Score: {Score}");
        Console.WriteLine($"Food: {Food.Position.x}, {Food.Position.y}");
        Console.WriteLine($"Snake({Player.Body.Count}); {Player.Head.x}, {Player.Head.y})");
    }

    private void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            Player.ChangeDirection(key);
        }
    }

    private void Logic()
    {
        Player.Move();
        if (Player.HasCollided(Width, Height))
        {
            GameOver = true;
            return;
        }

        if (Player.Head.Equals(Food.Position))
        {
            Player.TriggerEatFood();
        }
    }

    public GameState GetGameState()
    {
        return new GameState(Score, Player.Direction, Player.Body);
    }
    
    public void RestoreState(GameState state)
    {
        Score = state.GameScore;
        Player.Direction = state.SnakeDirection;
        Player.Body.Clear();
        Player.Body = state.SnakeBody;
    }
}