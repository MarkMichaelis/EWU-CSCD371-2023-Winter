using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests : FileLoggerTestsBase
{
    [TestMethod]
    public void ConfigureFileLogger_GivenFilePath_ReturnsFileLoggerWithSetFilePath()
    {
        LogFactory logFactory = new();
        logFactory.ConfigureFileLogger(FilePath);
    }

    [TestMethod]
    public void ConfigureFileLogger_GivenFilePath()
    {
        FileLogger fileLogger = (FileLogger)FileLogger.CreateLogger(nameof(LogFactoryTests), new FileLoggerConfiguration(FilePath));
    }
}
