using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class VisibleState : IElementState
    {
        public void Apply(LightElementNodeWithLifecycle element)
        {
            element.CssClasses.Remove("hidden");
            Console.WriteLine($"Element <{element.TagName}> is now visible.");
        }
    }
}
