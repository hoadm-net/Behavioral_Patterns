namespace Iterator.classes;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator(string order);
}