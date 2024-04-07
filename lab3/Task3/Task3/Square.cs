using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Square: Shape
    {
        public Square(IGraphic graphic)
        {
            this.graphic = graphic;
        }
        public override string ToString()
        {
            return "Square";
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {this} as {this.graphic}");
        }
    }
}
