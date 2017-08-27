using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;

namespace ProCSharp.Ch06
{
    public class HelloCollection
    {
        public IEnumerator GetEnumerator()
        {
//            yield return "Hello";
//            yield return "World!";
            return new Enumerator(0);
        }

        /*public void HelloWorld()
        {
            var helloCollection = new HelloCollection();
            foreach (var s in helloCollection)
            {
                Console.WriteLine(s);
            }
        }*/

        public class Enumerator : IEnumerator<string>, IEnumerator, IDisposable
        {
            private int state;
            private string current;

            public Enumerator(int state)
            {
                this.state = state;
            }

            public void Dispose()
            {
//                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                switch (state)
                {
                    case 0:
                        current = "Hello";
                        state = 1;
                        return true;
                    case 1:
                        current = "World";
                        state = 2;
                        return true;
                    case 2:
                        break;
                }
                return false;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public string Current
            {
                get { return current; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }
    }
}