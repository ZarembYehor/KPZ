using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle: Shape
    {
        public Triangle(IGraphic graphic)
        {
            this.graphic = graphic;
        }
        public override string ToString()
        {
            return "Triangle";
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {this} as {this.graphic}");
        }
    }
}
