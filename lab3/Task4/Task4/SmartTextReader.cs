using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReader: ISmartTextReader
    {
        public char[][] ReadTextFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File '{filePath}' not found.");
            }
            string[] lines = File.ReadAllLines(filePath);

            char[][] textArray = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                textArray[i] = lines[i].ToCharArray();
            }

            return textArray;
        }
    }
}
