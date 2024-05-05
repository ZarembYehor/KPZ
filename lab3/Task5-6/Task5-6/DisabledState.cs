using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class DisabledState : IElementState
    {
        public void Apply(LightElementNodeWithLifecycle element)
        {
            if (!element.CssClasses.Contains("disabled"))
            {
                element.CssClasses.Add("disabled");
            }
            Console.WriteLine($"Element <{element.TagName}> is now disabled.");
        }
    }
}
