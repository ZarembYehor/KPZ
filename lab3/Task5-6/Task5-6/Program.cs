using System.Runtime.InteropServices;
using System.Text;
using Task5_6;

var cssClasses = new List<string> { "main", "highlight" };
var root = new LightElementNodeWithLifecycle("div", "block", "normal", cssClasses);
var innerDiv = new LightElementNodeWithLifecycle("div", "inline-block", "normal", new List<string> { "inner-div" });

root.InsertChild(innerDiv);
root.ApplyStylesAndClasses();
root.PrintOuterHTML();
var textNode = LightTextNode.GetTextNode("Hello, World!");
innerDiv.InsertChild(textNode);
root.PrintOuterHTML();
root.RemoveChild(innerDiv);
root.PrintOuterHTML();