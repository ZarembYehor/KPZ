using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public interface IEventListener
    {
        void OnEvent(string eventName);
    }
}
