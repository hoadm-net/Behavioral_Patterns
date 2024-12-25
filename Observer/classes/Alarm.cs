namespace Observer.classes;

public class Alarm : IDevice
{
    public void Update(bool isMotionDetected)
    {
        if (isMotionDetected)
            Console.WriteLine("Alarm: Triggering alarm!");
        else
            Console.WriteLine("Alarm: Deactivating alarm.");
    }
}