using State.classes;

namespace State;

class Program
{
    static void Main(string[] args)
    {
        // Create a smart home system
        HomeSystem home = new HomeSystem();

        Console.WriteLine("== Scenario 1: Owner is at home ==");
        home.Notify("Front door opened.");

        Console.WriteLine("\n== Scenario 2: Owner is away ==");
        home.SetState(new AwayState());
        home.Notify("Motion detected at the front door.");

        Console.WriteLine("\n== Scenario 3: Security mode activated ==");
        home.SetState(new SecurityModeState());
        home.Notify("Glass break detected in living room.");
    }
}