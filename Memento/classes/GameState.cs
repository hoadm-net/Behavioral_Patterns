namespace Memento.classes;

public class GameState
{
    public int GameScore { get; }
    public string SnakeDirection { get; }
    public List<(int x, int y)> SnakeBody { get; }
    

    public GameState(int score, string direction, List<(int x, int y)> snakeBody)
    {
        GameScore = score;
        SnakeDirection = direction;
        SnakeBody = new List<(int x, int y)>(snakeBody);
    }
}