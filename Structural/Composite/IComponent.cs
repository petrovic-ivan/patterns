namespace Structural.Comp
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> c);
        IComponent<T> Find(T n);
        void Remove(T c);
        T Id { get; }
    }
}