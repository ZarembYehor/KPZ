using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public interface IVisitor
    {
        void Visit(TextElement textElement);
        void Visit(ImageElement imageElement);
    }
}
