namespace Observer.classes;

public interface IMotionSensor
{
    void Attach(IDevice device);
    void Detach(IDevice device);
    void Notify();
}