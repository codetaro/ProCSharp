using System;
using System.Collections.Generic;

namespace ProCSharp.Ch06
{
    public class HelloCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        public void HelloWorld()
        {
            var helloCollection = new HelloCollection();
            foreach (var s in helloCollection)
            {
                Console.WriteLine(s);
            }
        }
    }
}