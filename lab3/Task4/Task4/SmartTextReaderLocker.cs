using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReaderLocker: ISmartTextReader
    {
        private readonly ISmartTextReader _reader;
        private readonly Regex _pattern;

        public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
        {
            _reader = reader;
            _pattern = new Regex(pattern);
        }

        public char[][] ReadTextFile(string filePath)
        {
            if (!_pattern.IsMatch(filePath))
            {
                Console.WriteLine($"Access denied to file '{filePath}'!");
                return null;
            }

            return _reader.ReadTextFile(filePath);
        }
    }
}
