using System;
using System.IO;

public static class ActivityLogger
{
    private static readonly string logFile = "activity_log.txt";

    public static void Log(string activityName, int duration)
    {
        string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {activityName} | Duration: {duration} seconds";
        File.AppendAllLines(logFile, new[] { entry });
    }
}
