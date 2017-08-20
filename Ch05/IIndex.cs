namespace ProCSharp.Ch05
{
    public interface IIndex<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
}