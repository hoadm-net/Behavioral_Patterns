namespace State.classes;

public class AtHomeState : IHomeState
{
    public void Notify(string message)
    {
        Console.WriteLine($"[Smart Speaker] Notification: {message}");
    }
}