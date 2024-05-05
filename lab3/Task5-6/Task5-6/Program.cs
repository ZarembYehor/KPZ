using System.Runtime.InteropServices;
using System.Text;
using Task5_6;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
var root = new LightElementNodeWithLifecycle("div", "block", "normal", new List<string>());

var child1 = new LightElementNodeWithLifecycle("div", "block", "normal", new List<string> { "class1" });
var child2 = new LightElementNodeWithLifecycle("p", "inline", "normal", new List<string> { "class2" });
var textNode = LightTextNode.GetTextNode("Hello World");

child1.InsertChild(textNode);
root.InsertChild(child1);
root.InsertChild(child2);

Console.WriteLine("Глибокий обхід:");
var depthIterator = new DepthFirstIterator(root);

while (depthIterator.MoveNext())
{
    Console.WriteLine(depthIterator.Current);
}

Console.WriteLine("Широкий обхід:");
var breadthIterator = new BreadthFirstIterator(root);

while (breadthIterator.MoveNext())
{
    Console.WriteLine(breadthIterator.Current);
}