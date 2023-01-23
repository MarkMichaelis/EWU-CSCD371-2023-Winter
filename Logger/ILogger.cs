namespace Logger;

public interface ILogger
{
    void Log(LogLevel logLevel, string message);
    string LogSource { get; }

    public static abstract ILogger CreateLogger(string className, ILoggerConfiguration? configuration);
}
