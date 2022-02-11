using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private T _originator;
        private List<Memento<T>> _mementos = new List<Memento<T>>();

        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            Console.WriteLine($"Zapisywanie stanu...");
            _mementos.Add(new Memento<T>((T)_originator.Clone()));
        }

        public void Restore(DateTime dateTime) {

            var memento = _mementos.Where(x => x.DateTime <= dateTime).OrderBy(x => x.DateTime).LastOrDefault();
            if (memento == null)
                return;

            SaveState();
            Console.WriteLine($"Przywracanie stanu z {memento.DateTime}");
            _originator.Restore(memento.State);
        }

        public void Undo()
        {
            if (!_mementos.Any()) return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Przywracanie stanu z {memento.DateTime}");

            _originator.Restore(memento.State);
        }
        public void ShowHistory()
        {
            Console.WriteLine("Historia:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.DateTime);
            }
        }
    }
}
