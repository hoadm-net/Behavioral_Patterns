namespace Observer.classes;

public class SmartLight : IDevice
{
    public void Update(bool isMotionDetected)
    {
        if (isMotionDetected)
            Console.WriteLine("Smart Light: Turning ON.");
        else
            Console.WriteLine("Smart Light: Turning OFF.");
    }
}