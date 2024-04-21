using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        private Dictionary<string, List<IEventListener>> eventListeners;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            Children = new List<LightNode>();
            eventListeners = new Dictionary<string, List<IEventListener>>();
        }

        public void AddEventListener(string eventName, IEventListener listener)
        {
            if (!eventListeners.ContainsKey(eventName))
            {
                eventListeners[eventName] = new List<IEventListener>();
            }
            eventListeners[eventName].Add(listener);
        }

        public void TriggerEvent(string eventName)
        {
            if (eventListeners.ContainsKey(eventName))
            {
                foreach (var listener in eventListeners[eventName])
                {
                    listener.OnEvent(eventName);
                }
            }
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

            Console.WriteLine(outerHTML.ToString());
        }

        public void PrintInnerHTML()
        {
            StringBuilder innerHTML = new StringBuilder();

            foreach (var child in Children)
            {
                innerHTML.Append(child.ToString());
            }

            Console.WriteLine(innerHTML.ToString());
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