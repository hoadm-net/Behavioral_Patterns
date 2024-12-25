using Observer.classes;

namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        // MotionSensor - Subject
        MotionSensor sensor = new MotionSensor();

        // Smart devices - Observers
        SmartLight light = new SmartLight();
        SecurityCamera camera = new SecurityCamera();
        Alarm alarm = new Alarm();

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