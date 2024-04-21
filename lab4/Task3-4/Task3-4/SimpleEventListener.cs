using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    public class SimpleEventListener: IEventListener
    {
        public void OnEvent(string eventName)
        {
            Console.WriteLine($"Event '{eventName}' was triggered.");
        }
    }
}
