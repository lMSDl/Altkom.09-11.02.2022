using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<T[]>
    {
        private IEnumerable<T> enumerable;

        public Buffer(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return new BufferEnumerator<T>(enumerable);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
