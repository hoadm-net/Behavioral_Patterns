namespace Memento.classes;

public class Food
{
    public Food(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public (int x, int y) Position { get; private set; }
    private int Width { get; }
    private int Height { get; }

    public void Generate(List<(int x, int y)> snakeBody)
    {
        var random = new Random();
        do
        {
            Position = (random.Next(1, Width - 1), random.Next(1, Height - 1));
        } while (snakeBody.Contains(Position));
    }

    public void Draw()
    {
        Console.SetCursorPosition(Position.x, Position.y);
        Console.Write("*");
    }
}