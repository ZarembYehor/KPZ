using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Mage: IHero
    {
        public void UseAbility()
        {
            Console.WriteLine("Casting spell");
        }
    }
}
