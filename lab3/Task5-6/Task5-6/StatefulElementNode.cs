using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class StatefulElementNode : LightElementNodeWithLifecycle
    {
        private IElementState currentState;

        public StatefulElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
            : base(tagName, displayType, closingType, cssClasses)
        {
        }

        public void SetState(IElementState state)
        {
            currentState = state;
            currentState.Apply(this);
        }
    }
}
