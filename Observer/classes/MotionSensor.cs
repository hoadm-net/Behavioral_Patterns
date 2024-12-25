namespace Observer.classes;

public class MotionSensor : IMotionSensor
{
    private List<IDevice> _devices = new List<IDevice>();
    private bool _isMotionDetected;

    public bool IsMotionDetected
    {
        get { return _isMotionDetected; }
        set
        {
            _isMotionDetected = value;
            Notify(); // Thông báo khi có chuyển động
        }
    }

    public void Attach(IDevice device)
    {
        _devices.Add(device);
    }

    public void Detach(IDevice device)
    {
        _devices.Remove(device);
    }

    public void Notify()
    {
        foreach (var device in _devices)
        {
            device.Update(_isMotionDetected);
        }
    }
}