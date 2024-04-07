using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ArtifactDecorator: InventoryDecorator
    {
        public ArtifactDecorator(IHero hero) : base(hero) { }

        public override void ShowInventory()
        {
            Console.WriteLine("Artifacts:\n");
            foreach (string item in this.items)
            {
                Console.WriteLine(item);
            }
        }

        public override void AddItem(string item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(string item)
        {
            this.items.Remove(item);
        }
    }
}
