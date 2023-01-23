namespace Logger;

public class LogFactory
{
    public string? FileName { get; set; }

    public ILogger? CreateLogger(string className) => 
        FileName is null ? null : new FileLogger(className, FileName);

    public void ConfigureFileLogger(string fileName) => FileName=fileName;
}
