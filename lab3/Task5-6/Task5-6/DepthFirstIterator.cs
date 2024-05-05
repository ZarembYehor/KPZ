using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class DepthFirstIterator : ILightNodeEnumerator
    {
        private readonly Stack<LightNode> stack;
        private LightNode current;

        public DepthFirstIterator(LightNode root)
        {
            stack = new Stack<LightNode>();
            stack.Push(root);
            current = null;
        }

        public LightNode Current => current;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (stack.Count == 0) return false;
            current = stack.Pop();
            if (current is LightElementNodeWithLifecycle elementNode)
            {
                var children = elementNode.Children;
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    stack.Push(children[i]);
                }
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException("Reset is not implemented.");
        }
    }
}
