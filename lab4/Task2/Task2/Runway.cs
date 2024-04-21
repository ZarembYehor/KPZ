using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsBusy { get; set; } = false;

        public void Occupy()
        {
            IsBusy = true;
            Console.WriteLine($"Runway {Id} is now busy.");
        }

        public void Free()
        {
            IsBusy = false;
            Console.WriteLine($"Runway {Id} is now free.");
        }
    }
}