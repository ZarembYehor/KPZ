using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class BreadthFirstIterator : ILightNodeEnumerator
    {
        private readonly Queue<LightNode> queue;
        private LightNode current;

        public BreadthFirstIterator(LightNode root)
        {
            queue = new Queue<LightNode>();
            queue.Enqueue(root);
            current = null;
        }

        public LightNode Current => current;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (queue.Count == 0) return false;
            current = queue.Dequeue();
            if (current is LightElementNodeWithLifecycle elementNode)
            {
                var children = elementNode.Children;
                foreach (var child in children)
                {
                    queue.Enqueue(child);
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
