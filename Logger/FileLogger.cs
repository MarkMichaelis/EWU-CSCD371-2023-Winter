namespace Logger;

public class FileLogger : ILogger
{
    public FileLogger(string logSource, string filePath)
    {
        LogSource = logSource;
        FilePath=filePath;
        File = new FileInfo(FilePath);
    }

    public string LogSource { get; }
    public string FilePath { get; }

    FileInfo File { get; }

    public static FileLogger CreateLogger(string className, string fileName) =>
        new (
            className??throw new ArgumentNullException(nameof(className)), 
            fileName??throw new ArgumentNullException(nameof(fileName)));
    

    // TODO: Switch to return FileLogger using C# 9.0 covariant returns
    public static ILogger CreateLogger(string className, ILoggerConfiguration? configuration) => 
        configuration is FileLoggerConfiguration fileLoggerConfiguration
            ? FileLogger.CreateLogger(className, fileLoggerConfiguration.FileName)
            : throw new ArgumentNullException(nameof(configuration));

    public void Log(LogLevel logLevel, string message)
    {
        using StreamWriter writer = File.AppendText();
        writer.WriteLine($"{ DateTime.Now },{LogSource},{logLevel},{message}");
    }
}
