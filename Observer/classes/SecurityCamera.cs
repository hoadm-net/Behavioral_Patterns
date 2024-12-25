namespace Observer.classes;

public class SecurityCamera : IDevice
{
    public void Update(bool isMotionDetected)
    {
        if (isMotionDetected)
            Console.WriteLine("Security Camera: Starting recording.");
        else
            Console.WriteLine("Security Camera: Stopping recording.");
    }
}