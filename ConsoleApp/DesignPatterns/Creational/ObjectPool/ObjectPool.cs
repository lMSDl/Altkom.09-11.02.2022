using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        private ICollection<T> _free;

        public ObjectPool(int numberOfItems, Func<T> func)
        {
            _free = Enumerable.Range(1, numberOfItems).Select(x => func()).ToList();
        }

        public T Aquire()
        {
            lock (_free)
            {
                var item = _free.FirstOrDefault();
                _free.Remove(item);
                return item;
            }
        }

        public void Release(T item)
        {
            lock(_free)
            {
                _free.Add(item);
            }
        }
    }
}
