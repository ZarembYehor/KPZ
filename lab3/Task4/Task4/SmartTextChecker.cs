using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextChecker: ISmartTextReader
    {
        private readonly ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadTextFile(string filePath)
        {
            Console.WriteLine($"Opening file '{filePath}'...");

            char[][] textArray = _reader.ReadTextFile(filePath);

            Console.WriteLine($"File '{filePath}' opened successfully.");

            int totalLines = textArray.Length;
            int totalChars = 0;
            foreach (char[] line in textArray)
            {
                totalChars += line.Length;
            }

            Console.WriteLine($"Total lines: {totalLines}");
            Console.WriteLine($"Total characters: {totalChars}");

            Console.WriteLine($"Closing file '{filePath}'...");

            return textArray;
        }
    }
}