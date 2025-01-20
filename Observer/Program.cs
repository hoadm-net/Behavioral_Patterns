using Observer.classes;

namespace Observer;

internal class Program
{
    private static void Main(string[] args)
    {
        // MotionSensor - Subject
        var sensor = new MotionSensor();

        // Smart devices - Observers
        var light = new SmartLight();
        var camera = new SecurityCamera();
        var alarm = new Alarm();

        // Register
        sensor.Attach(light);
        sensor.Attach(camera);
        sensor.Attach(alarm);

        // Mô phỏng phát hiện chuyển động
        Console.WriteLine("Motion detected:");
        sensor.IsMotionDetected = true;

        Console.WriteLine("\nNo motion detected:");
        sensor.IsMotionDetected = false;
    }
}