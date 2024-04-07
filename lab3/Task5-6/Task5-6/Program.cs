using System.Runtime.InteropServices;
using System.Text;
using Task5_6;

string[] lines = File.ReadAllLines("D:\\КПЗ\\KPZ\\lab3\\Task5-6\\Task5-6\\book.txt");

var html = new LightElementNode("html", "block", "closing", new List<string>());
var h1 = new LightElementNode("h1", "block", "closing", new List<string>());
h1.Children.Add(LightTextNode.GetTextNode(lines[0]));
html.Children.Add(h1);

for (int i = 1; i < lines.Length; i++)
{
    string line = lines[i];

    if (line.Length < 20)
    {
        var h2 = new LightElementNode("h2", "block", "closing", new List<string>());
        h2.Children.Add(LightTextNode.GetTextNode(lines[i]));
        html.Children.Add(h2);
    }
    else if (!string.IsNullOrEmpty(line) && char.IsWhiteSpace(line[0]))
    {
        var blockquote = new LightElementNode("blockquote", "block", "closing", new List<string>());
        blockquote.Children.Add(LightTextNode.GetTextNode(lines[i]));
        html.Children.Add(blockquote);
    }
    else
    {
        var p = new LightElementNode("p", "block", "closing", new List<string>());
        p.Children.Add(LightTextNode.GetTextNode(lines[i]));
        html.Children.Add(p);
    }
}

html.PrintOuterHTML();

long totalMemory = CalculateMemoryUsage(html);
Console.WriteLine($"Size of tree: {totalMemory} byte");
static long CalculateMemoryUsage(object obj)
{
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();

    long totalMemory = GC.GetTotalMemory(true);

    return totalMemory;
}