namespace ExceptionLogger
{
    public static class Logger
    {
        public static void Log(Exception ex)
        {
            string logPath = "log.txt"; // Log file path
            string logMessage = $"[{DateTime.Now}] {ex.Message}\n{ex.StackTrace}\n";
            File.AppendAllText(logPath, logMessage);
        }
    }
}
