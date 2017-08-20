using System;

namespace ProCSharp.Ch05
{
    public class MethodOverloads
    {
        public void Foo<T>(T obj)
        {
            Console.WriteLine("Foo<T>(T obj), obj type: {0}", obj.GetType().Name);
        }

        public void Foo(int x)
        {
            Console.WriteLine("Foo(int x)");
        }

        public void Bar<T>(T obj)
        {
            Foo(obj);
        }
    }
}