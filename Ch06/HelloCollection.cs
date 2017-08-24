using System;
using System.Collections.Generic;

namespace ProCSharp.Ch06
{
    public class HelloCollection
    {
        public IEnumerator GetEnumerator()
        {
            return Enumerator(0);
        }

        public class Enumerator : IEnumerator<string>, IEnumerator, IDisposable
        {
            private int state;
            private string current;

            public Enumerator(int state)
            {
                this.state = state;
            }

            bool System.Collections.IEnumerator.MoveNext()
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

            void System.Collections.IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            string System.Collections.Generic.IEnumerator<string>.Current
            {
                get { return current; }
            }

            object System.Collections.IEnumerator.Current
            {
                get { return current; }
            }

            void IDisposable.Dispose()
            {
            }
        }
    }
}