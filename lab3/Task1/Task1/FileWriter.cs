using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileWriter
    {
        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter("D:\\КПЗ\\KPZ\\lab3\\Task1\\Task1\\log.txt", true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter("D:\\КПЗ\\KPZ\\lab3\\Task1\\Task1\\log.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
