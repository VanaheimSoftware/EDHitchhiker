using System.Timers;

namespace EDHitchhiker.VanaheimSoftware.Utils
{
    public class LogWatcher
    {
        private readonly Object lockObject = new();

        private string? routeFile;
        private DateTime? routeLatest = DateTime.MinValue;
        private readonly System.Timers.Timer routeTimer = new System.Timers.Timer(Constants.TimerInterval);

        private DateTime? logLatest = DateTime.MinValue;
        private string logFile = "";
        private readonly System.Timers.Timer logTimer = new System.Timers.Timer(Constants.TimerInterval);

        public event EventHandler? OnNewRoute;
        public event EventHandler<string>? OnLogChange;

        public string CurrentLogWatched
        {
            get
            {
                lock (lockObject)
                {
                    return logFile;
                }
            }
        }

        public LogWatcher()
        {
            InitializeRoute();
            InitializeLogs();
        }

        // Route handling
        private void InitializeRoute()
        {
            routeFile = Path.Combine(Constants.LogFolder, Constants.RouteFileName);
            routeLatest = FileLastModified(routeFile);
            routeTimer.Elapsed += new ElapsedEventHandler(RouteTimerExecute);
            routeTimer.Start();
        }

        private static DateTime FileLastModified(string file)
        {
            FileInfo? fileInfo = new(file);
            return fileInfo.LastWriteTimeUtc;
        }

        private void RouteTimerExecute(object? sender, ElapsedEventArgs e)
        {
            routeTimer.Stop();
            if (routeFile != null) {
                DateTime latestRoute = FileLastModified(routeFile);
                if (routeLatest != latestRoute) {
                    routeLatest = latestRoute;
                    OnNewRoute?.Invoke(this, EventArgs.Empty);
                }
            }
            routeTimer.Start();
        }

        // Log files handling
        private void InitializeLogs()
        {
            string[] journals = QueryLogFiles();

            if (journals.Length > 0)
            {
                string last = journals[journals.Length - 1];
                logLatest = FileLastModified(last);
                lock (lockObject)
                {
                    logFile = Path.GetFileName(last);
                }
            }

            logTimer.Elapsed += new ElapsedEventHandler(LogTimerExecute);
            logTimer.Start();
        }

        private string[] QueryLogFiles()
        {
            string[] journals = Directory.GetFiles(Constants.LogFolder, Constants.LogFilePattern);
            Array.Sort(journals);

            return journals;
        }

        private void LogTimerExecute(object? sender, ElapsedEventArgs e)
        {
            logTimer.Stop();

            string[] journals = QueryLogFiles();

            if (journals.Length > 0)
            {
                bool invoke = false;

                string last = journals[journals.Length - 1];
                DateTime latestWrite = FileLastModified(last);
                string fileName = Path.GetFileName(last);

                if (logFile == fileName)
                {
                    if (latestWrite.CompareTo(logLatest) > 0)
                    {
                        lock (lockObject)
                        {
                            logLatest = latestWrite;
                            invoke = true;
                        }
                    }
                }
                else
                {
                    lock (lockObject)
                    {
                        logFile = fileName;
                        logLatest = latestWrite;
                    }
                    invoke = true;
                }

                if (invoke)
                {
                    string fileInvoke = "";
                    lock (lockObject)
                    {
                        fileInvoke = logFile;
                    }
                    OnLogChange?.Invoke(this, fileInvoke);
                    
                }
            }

            logTimer.Start();
        }
    }
}
