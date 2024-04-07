using Task4;

ISmartTextReader reader = new SmartTextReader();
ISmartTextReader restrictedReader = new SmartTextReaderLocker(reader, @"restricted\d+.txt");

try
{
    char[][] textArray1 = restrictedReader.ReadTextFile("D:\\КПЗ\\KPZ\\lab3\\Task4\\Task4\\text.txt");
    char[][] textArray2 = restrictedReader.ReadTextFile("D:\\КПЗ\\KPZ\\lab3\\Task4\\Task4\\restricted1.txt");
    char[][] textArray3 = restrictedReader.ReadTextFile("D:\\КПЗ\\KPZ\\lab3\\Task4\\Task4\\restricted2.txt");

    if (textArray1 != null)
    {
        Console.WriteLine("Contents of file1.txt:");
        foreach (var line in textArray1)
        {
            Console.WriteLine(new string(line));
        }
    }

    if (textArray2 != null)
    {
        Console.WriteLine("Contents of restricted1.txt:");
        foreach (var line in textArray2)
        {
            Console.WriteLine(new string(line));
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
