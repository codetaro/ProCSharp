namespace ProCSharp.Ch05
{
    public interface IDisplay<in T>
    {
        void Show(T item);
    }
}