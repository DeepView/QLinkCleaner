using System.Threading;

namespace QLinkCleaner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string appName = @"QLinkCleaner";
            using Mutex mutex = new(true, appName);
            // Check if another instance is already running
            if (!mutex.WaitOne(0, false))
            {
                // If another instance is running, exit the application
                MessageBox.Show(
                    "Another instance is already running.",
                    "Instance Check",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            if (args.Length == 0 || args == null) args = [string.Empty];
            // If this is the first instance, continue with application startup
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(args));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

        }
    }
}