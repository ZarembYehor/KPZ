using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class ImageElement : IElement
    {
        public string ImagePath { get; }

        public ImageElement(string imagePath)
        {
            ImagePath = imagePath;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
