using NT.Utilities.NT.Utilities;

using System;
using System.IO;
using System.Threading.Tasks;

namespace NT.Logging
{
    public static class Logger
    {
        private static string logFilePath;

        static Logger()
        {
            Configure();
        }

        private static void Configure()
        {
           logFilePath = $"{Directory.GetCurrentDirectory()}/log.txt";
        }

        public static async Task LogAsync(string message)
        {
           await WriteLogAsync(message);
        }

        public static async Task LogAsync(Exception e)
        {
            Exception original = e.GetOriginalException();
            await WriteLogAsync($"" +
                    $"\nError Message: {original.Message}\n" +
                    $"Stacktrace:\n{e.StackTrace}\n" +
                    $"Source: {e.Source}\n" +
                    $"Original Exception: {original.Message} \n" +
                    $"Stracktrace\n{original.StackTrace}\n" +
                    $"Source: {original.Source}\n");
        }

        private static async Task WriteLogAsync(string logMessage)
        {           
            await File.AppendAllTextAsync(
                logFilePath,
                $"[{DateTime.UtcNow}]\n" +
                $"{logMessage}");
        }
    }
}
