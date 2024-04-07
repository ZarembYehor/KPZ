using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileLoggerAdapter: ILogger
    {
        private readonly Logger logger;
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(Logger logger, FileWriter fileWriter)
        {
            this.logger = logger;
            this.fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            logger.Log(message);
            fileWriter.WriteLine("[LOG]: " + message);
        }

        public void Error(string message)
        {
            logger.Error(message);
            fileWriter.WriteLine("[ERROR]: " + message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
            fileWriter.WriteLine("[WARN]: " + message);
        }
    }
}
