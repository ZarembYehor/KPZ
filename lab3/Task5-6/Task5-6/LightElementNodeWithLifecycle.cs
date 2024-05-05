using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class LightElementNodeWithLifecycle: LightNodeWithLifecycle
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNodeWithLifecycle(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            Children = new List<LightNode>();
            OnCreated();
        }

        public override void OnCreated()
        {
            Console.WriteLine($"Element <{TagName}> created.");
        }

        public override void OnInserted()
        {
            Console.WriteLine($"Element <{TagName}> inserted.");
        }

        public void InsertChild(LightNode child)
        {
            Children.Add(child);
            OnInserted();
        }

        public override void OnRemoved()
        {
            Console.WriteLine($"Element <{TagName}> removed.");
        }

        public void RemoveChild(LightNode child)
        {
            Children.Remove(child);
            OnRemoved();
        }

        public override void OnStylesApplied()
        {
            Console.WriteLine($"Styles applied to <{TagName}>.");
        }

        public override void OnClassListApplied()
        {
            Console.WriteLine($"Class list applied to <{TagName}>.");
        }

        public void ApplyStylesAndClasses()
        {
            OnStylesApplied();
            OnClassListApplied();
        }

        public void PrintOuterHTML()
        {
            StringBuilder outerHTML = new StringBuilder();

            outerHTML.Append($"<{TagName}");

            foreach (var cssClass in CssClasses)
            {
                outerHTML.Append($" class=\"{cssClass}\"");
            }

            if (ClosingType == "self-closing")
            {
                outerHTML.Append(" />");
            }
            else
            {
                outerHTML.Append(">");
                foreach (var child in Children)
                {
                    outerHTML.Append(child.ToString());
                }
                outerHTML.Append($"</{TagName}>");
            }

            Console.WriteLine(outerHTML);
            OnTextRendered();
        }
    }
}
