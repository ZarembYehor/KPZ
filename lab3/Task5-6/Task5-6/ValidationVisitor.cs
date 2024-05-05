using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class ValidationVisitor : IVisitor
    {
        public bool IsValid { get; private set; } = true;

        public void Visit(TextElement textElement)
        {
            if (string.IsNullOrWhiteSpace(textElement.Text))
            {
                IsValid = false;
                Console.WriteLine("Invalid TextElement: Text is empty or null.");
            }
        }

        public void Visit(ImageElement imageElement)
        {
            if (string.IsNullOrWhiteSpace(imageElement.ImagePath))
            {
                IsValid = false;
                Console.WriteLine("Invalid ImageElement: ImagePath is empty or null.");
            }
        }
    }
}
