namespace DeepCopy
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}