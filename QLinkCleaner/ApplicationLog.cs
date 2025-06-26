using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLinkCleaner
{
    public class ApplicationLog
    {
        public ApplicationLog(string logFilePath)
        {
            LogFilePath = logFilePath;
            if (!File.Exists(LogFilePath))
            {
                File.Create(LogFilePath).Close(); // Ensure the file exists
            }
        }
        public string LogFilePath { get; set; }
        public void WriteLine(string category, string message)
        {
            try
            {
                File.AppendAllText(LogFilePath, $"[{DateTime.Now}] [{category}] : {message}\n");
            }
            catch (Exception ex)
            {
                // Handle exceptions related to file writing, e.g., log to console or another file
                Console.WriteLine($"Error writing to log: {ex.Message}");
            }
        }
    }
}
