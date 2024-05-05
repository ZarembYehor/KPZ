using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class HiddenState : IElementState
    {
        public void Apply(LightElementNodeWithLifecycle element)
        {
            if (!element.CssClasses.Contains("hidden"))
            {
                element.CssClasses.Add("hidden");
            }
            Console.WriteLine($"Element <{element.TagName}> is now hidden.");
        }
    }
}
