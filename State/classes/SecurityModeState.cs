namespace State.classes;

public class SecurityModeState : IHomeState
{
    public void Notify(string message)
    {
        Console.WriteLine($"[Smart Speaker] Security Alert: {message}");
        Console.WriteLine($"[SMS] Security Alert: {message}");
    }
}