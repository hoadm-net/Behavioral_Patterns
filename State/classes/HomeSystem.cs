namespace State.classes;

public class HomeSystem
{
    private IHomeState _currentState;

    public HomeSystem()
    {
        // Default state
        _currentState = new AtHomeState();
    }

    public void SetState(IHomeState state)
    {
        _currentState = state;
    }

    public void Notify(string message)
    {
        _currentState.Notify(message);
    }
}