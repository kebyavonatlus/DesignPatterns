namespace Open_ClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
