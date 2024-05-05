using System.Runtime.InteropServices;
using System.Text;
using Task5_6;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
var elements = new List<IElement>
        {
            new TextElement("Hello, World!"),
            new ImageElement("/images/example.png"),
            new TextElement(""),
            new ImageElement("")
        };
var validationVisitor = new ValidationVisitor();
foreach (var element in elements)
{
    element.Accept(validationVisitor);
}
Console.WriteLine($"All elements are valid: {validationVisitor.IsValid}");