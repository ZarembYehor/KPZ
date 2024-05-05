using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public interface IElementState
    {
        void Apply(LightElementNodeWithLifecycle element);
    }
}
