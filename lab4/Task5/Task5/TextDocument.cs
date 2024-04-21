using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class TextDocument
    {
        private string _state;
        private string _text;

        public TextDocument(string initialState, string initialText)
        {
            _state = initialState;
            _text = initialText;
            Console.WriteLine($"Originator: My initial state is: {_state}, text: {_text}");
        }

        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(10);
            _text = GenerateRandomString(20);
            Console.WriteLine($"Originator: My state has changed to: {_state}, and text to: {_text}");
        }

        private string GenerateRandomString(int length)
        {
            var allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = new System.Text.StringBuilder();

            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(allowedSymbols[random.Next(allowedSymbols.Length)]);
            }

            return result.ToString();
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_state, _text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public void Restore(IMemento memento)
        {
            if (memento is ConcreteMemento)
            {
                _state = memento.GetState();
                _text = memento.GetText();
                Console.WriteLine($"Originator: My state and text have been restored to: {_state}, {_text}");
            }
            else
            {
                throw new ArgumentException("Unknown Memento type");
            }
        }
    }
}
