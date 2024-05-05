using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class RemoveElementCommand : ICommand
    {
        private LightElementNodeWithLifecycle parent;
        private LightNode element;

        public RemoveElementCommand(LightElementNodeWithLifecycle parent, LightNode element)
        {
            this.parent = parent;
            this.element = element;
        }

        public void Execute()
        {
            parent.RemoveChild(element);
            Console.WriteLine($"Element {element} removed from {parent.TagName}.");
        }

        public void Undo()
        {
            parent.InsertChild(element);
            Console.WriteLine($"Element {element} added back to {parent.TagName}.");
        }
    }
}
