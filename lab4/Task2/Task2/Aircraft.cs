using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Aircraft
    {
        public string Name { get; }
        public CommandCentre CommandCentre { get; }

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            CommandCentre = commandCentre;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to land.");
            CommandCentre.HandleLandingRequest(this);
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to take off.");
            CommandCentre.HandleTakeOffRequest(this);
        }
    }
}
