using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class LightElementNode: LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            Children = new List<LightNode>();
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
        }
        public void PrintInnerHTML()
        {
            StringBuilder innerHTML = new StringBuilder();

            foreach (var child in Children)
            {
                innerHTML.Append(child.ToString());
            }

            Console.WriteLine(innerHTML);
        }

        public override string ToString()
        {
            StringBuilder html = new StringBuilder();

            html.Append($"<{TagName}");

            foreach (var cssClass in CssClasses)
            {
                html.Append($" class=\"{cssClass}\"");
            }

            if (ClosingType == "self-closing")
            {
                html.Append(" />");
            }
            else
            {
                html.Append(">");
                foreach (var child in Children)
                {
                    html.Append(child.ToString());
                }
                html.Append($"</{TagName}>");
            }

            return html.ToString();
        }
    }
}