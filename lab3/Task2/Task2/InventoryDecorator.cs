using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class InventoryDecorator
    {
        protected IHero hero;
        protected List<string> items = new List<string>();

        public InventoryDecorator(IHero hero)
        {
            this.hero = hero;
        }

        public virtual void UseAbility()
        {
            hero.UseAbility();
        }

        public abstract void ShowInventory();
        public abstract void AddItem(string item);
        public abstract void RemoveItem(string item);
    }
}
