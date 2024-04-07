using Task1;

Logger logger = new Logger();
FileWriter fileWriter = new FileWriter();
ILogger fileLogger = new FileLoggerAdapter(logger, fileWriter);

fileLogger.Log("This is a log message");
fileLogger.Error("This is an error message");
fileLogger.Warn("This is a warning message");