using System;

namespace ProCSharp.Ch04
{
    class SomeClass : IDisposable
    {
        /* This class MUST contain an implementation of the
         IDisposable.Dispose() method, otherwise
         you get a compilation error. */
        public void Dispose()
        {
            // implementation of Dispose() method
        }
        // rest of class
    }
}