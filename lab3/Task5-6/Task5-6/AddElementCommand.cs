using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class AddElementCommand : ICommand
    {
        private LightElementNodeWithLifecycle parent;
        private LightNode element;

        public AddElementCommand(LightElementNodeWithLifecycle parent, LightNode element)
        {
            this.parent = parent;
            this.element = element;
        }

        public void Execute()
        {
            parent.InsertChild(element);
            Console.WriteLine($"Element {element} added to {parent.TagName}.");
        }

        public void Undo()
        {
            parent.RemoveChild(element);
            Console.WriteLine($"Element {element} removed from {parent.TagName}.");
        }
    }
}
