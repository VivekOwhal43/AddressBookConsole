using Microsoft.Extensions.Logging;
using NLog;
public class NLogDemo
{
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    public void LogDebug(string message)
    {
        logger.Debug(message);
        logger.GetHashCode();
    }

    public void LogWarn(string message)
    {
        logger.Warn(message);
    }

    public void LogErr(string message)
    {
        logger.Error(message);
    }
}