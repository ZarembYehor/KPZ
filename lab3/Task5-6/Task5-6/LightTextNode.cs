using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class LightTextNode: LightNode, ITextFlyweight
    {
        public string Text { get; }

        private LightTextNode(string text)
        {
            Text = text;
        }
        public static LightTextNode GetTextNode(string text)
        {
            if (!textNodes.ContainsKey(text))
            {
                textNodes[text] = new LightTextNode(text);
            }
            return textNodes[text];
        }

        private static readonly Dictionary<string, LightTextNode> textNodes = new Dictionary<string, LightTextNode>();
        public override string ToString()
        {
            return Text;
        }
    }
}
