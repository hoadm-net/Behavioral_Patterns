namespace Memento.classes;

public class Snake
{
    public Snake(int startX, int startY)
    {
        Body = new List<(int x, int y)> { (startX, startY) };
        Direction = "RIGHT";
    }

    public List<(int x, int y)> Body { get; set; }
    public string Direction { get; set; }

    public (int x, int y) Head => Body.First();

    public event EventHandler OnEatFood;

    public void Draw()
    {
        foreach (var part in Body)
        {
            Console.SetCursorPosition(part.x, part.y);
            Console.Write("O");
        }
    }

    public void ChangeDirection(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (Direction != "DOWN") Direction = "UP";
                break;
            case ConsoleKey.DownArrow:
                if (Direction != "UP") Direction = "DOWN";
                break;
            case ConsoleKey.LeftArrow:
                if (Direction != "RIGHT") Direction = "LEFT";
                break;
            case ConsoleKey.RightArrow:
                if (Direction != "LEFT") Direction = "RIGHT";
                break;
        }
    }

    public void Move()
    {
        var newHead = Direction switch
        {
            "UP" => (Head.x, Head.y - 1),
            "DOWN" => (Head.x, Head.y + 1),
            "LEFT" => (Head.x - 1, Head.y),
            "RIGHT" => (Head.x + 1, Head.y),
            _ => Head
        };
        Body.Insert(0, newHead);
        Body.RemoveAt(Body.Count - 1);
    }

    public void Grow()
    {
        Body.Add(Body.Last());
    }

    public bool HasCollided(int width, int height)
    {
        return Head.x <= 0 || Head.x >= width - 1 ||
               Head.y <= 0 || Head.y >= height - 1 ||
               Body.Skip(1).Contains(Head);
    }

    public void TriggerEatFood()
    {
        OnEatFood?.Invoke(this, EventArgs.Empty);
    }
}