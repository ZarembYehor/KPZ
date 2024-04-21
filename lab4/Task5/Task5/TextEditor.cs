using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class TextEditor
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private TextDocument _originator;

        public TextEditor(TextDocument originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Originator's state...");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                Console.WriteLine("Caretaker: No mementos to undo.");
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Caretaker: Restoring to memento: {memento.GetName()}");

            _originator.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");
            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.ToString());
            }
        }
    }
}
