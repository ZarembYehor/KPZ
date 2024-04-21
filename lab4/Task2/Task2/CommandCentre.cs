using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private Dictionary<Aircraft, Runway> _aircraftRunwayMap = new Dictionary<Aircraft, Runway>();

        public CommandCentre(List<Runway> runways)
        {
            _runways.AddRange(runways);
        }

        public void HandleLandingRequest(Aircraft aircraft)
        {
            var availableRunway = _runways.Find(r => !r.IsBusy);
            if (availableRunway != null)
            {
                availableRunway.Occupy();
                _aircraftRunwayMap[aircraft] = availableRunway;
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {availableRunway.Id}.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} could not land, all runways are busy.");
            }
        }

        public void HandleTakeOffRequest(Aircraft aircraft)
        {
            if (_aircraftRunwayMap.TryGetValue(aircraft, out var assignedRunway))
            {
                assignedRunway.Free();
                _aircraftRunwayMap.Remove(aircraft);
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} could not take off, it is not assigned to a runway.");
            }
        }
    }
}
