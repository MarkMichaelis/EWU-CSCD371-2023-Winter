namespace Logger;

public class FileLoggerConfiguration : ILoggerConfiguration
{
    public FileLoggerConfiguration(string fileName)
    {
        FileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
    }
    public string FileName { get; }

}