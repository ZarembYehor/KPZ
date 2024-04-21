using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly string _text;
        private readonly string _name;

        public ConcreteMemento(string state, string text, string name)
        {
            _state = state;
            _text = text;
            _name = name;
        }

        public string GetName() => _name;

        public string GetState() => _state;

        public string GetText() => _text;

        public override string ToString() => $"Memento [Name={_name}, State={_state}, Text={_text}]";
    }
}
