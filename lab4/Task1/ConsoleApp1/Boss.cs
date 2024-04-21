using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Boss: AbstractHandler
    {
        public override object Handle(object request)
        {
            Console.WriteLine("Чи хочете ви зв'язатись з Головою компанії");
            string answer = Console.ReadLine();
            if (answer == "Так")
            {
                return $"Вітаю, ви зв'язались з тех-підтримкою в режимі Голова компанії.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
