namespace Memento.classes;

// CareTaker    
public class GameHistory
{
    private Stack<GameState> _history = new Stack<GameState>();

    public void Save(GameState state)
    {
        _history.Push(state);
    }

    public GameState GetLastState()
    {
        return _history.Count > 0 ? _history.Pop() : null;
    }
}