using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Iterator
{
    public class BufferEnumerator<T> : IEnumerator<T[]>
    {
        private IEnumerator<T> enumerator;
        private T buffer;

        public BufferEnumerator(IEnumerable<T> enumerable)
        {
            enumerator = enumerable.GetEnumerator();
            Reset();
        }

        public T[] Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            enumerator.Dispose();
            enumerator = null;
            Current = null;
        }

        public bool MoveNext()
        {
            if(enumerator.MoveNext())
            {
                Current = new[] { buffer, enumerator.Current };
                buffer = enumerator.Current;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            enumerator.Reset();
            if (enumerator.MoveNext())
                buffer = enumerator.Current;
            else
                buffer = default;

            Current = new T[2];
        }
    }
}
