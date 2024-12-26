namespace Iterator.classes;

public interface IIterator<T>
{
    T Current { get; }
    bool Next();
    void Reset();
}