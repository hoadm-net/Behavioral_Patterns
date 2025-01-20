namespace State.classes;

public class AwayState : IHomeState
{
    public void Notify(string message)
    {
        Console.WriteLine($"[SMS] Notification: {message}");
    }
}