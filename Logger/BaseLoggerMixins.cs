namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this ILogger logger, string message) =>
        (logger??throw new ArgumentNullException(nameof(logger))).Log(LogLevel.Error, message);
    public static void Warning(this ILogger logger, string message) =>
        (logger??throw new ArgumentNullException(nameof(logger))).Log(LogLevel.Warning, message);
    public static void Information(this ILogger logger, string message) =>
        (logger??throw new ArgumentNullException(nameof(logger))).Log(LogLevel.Information, message);
    public static void Debug(this ILogger logger, string message) =>
        (logger??throw new ArgumentNullException(nameof(logger))).Log(LogLevel.Debug, message);
}
