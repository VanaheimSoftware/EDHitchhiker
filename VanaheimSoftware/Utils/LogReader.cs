
namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class LogReader {
        private readonly object logLocker = new();

        private readonly LogWatcher logWatcher;
        private string logFileName;
        private long lastReadLineNumber = 0;

        public event EventHandler<string>? OnRead;


        public LogReader(LogWatcher watcher) {
            this.logWatcher = watcher;
            logFileName = this.logWatcher.CurrentLogWatched;
            CalculateLines();

            this.logWatcher.OnNewRoute += NewRoute;
            this.logWatcher.OnLogChange += LogChange;
        }

        ~LogReader() {
            this.logWatcher.OnNewRoute -= NewRoute;
            this.logWatcher.OnLogChange -= LogChange;
        }


        public void ReloadRoute() {
            NewRoute(this, new());
        }

        private void NewRoute(object? sender, EventArgs e) {
            try {
                using FileStream fs = File.Open(Path.Combine(Constants.LogFolder, Constants.RouteFileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using StreamReader sr = new(fs, true);
                string data = sr.ReadToEnd();
                if (!String.IsNullOrEmpty(data)) {
                    OnRead?.Invoke(this, data);
                }
            } catch (IOException io) {
                Console.WriteLine("LogReader.NewRoute:{0}{1}",
                    Environment.NewLine,
                    io);
                this.logWatcher.OnNewRoute -= NewRoute;
            }
        }

        private void LogChange(object? sender, string logFile) {
            string currentLogFile = this.logWatcher.CurrentLogWatched;
            if (currentLogFile != logFileName) {
                ReadLogFile();  // Finish current up, if need to
                lock (logLocker) {
                    logFileName = currentLogFile;
                    lastReadLineNumber = 0;
                }
            }
            ReadLogFile();
        }



        private void CalculateLines() {
            lock (logLocker) {
                if (String.IsNullOrEmpty(logFileName))
                    return;
                string? line;
                long lineNumber = 0;
                using FileStream fs = File.Open(Path.Combine(Constants.LogFolder, logFileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using StreamReader sr = new(fs, true);
                while (!sr.EndOfStream && (line = sr.ReadLine()) != null) {
                    ++lineNumber;
                }

                lastReadLineNumber = lineNumber;
            }
        }

        private void ReadLogFile() {
            try {
                lock (logLocker) {
                    if (String.IsNullOrEmpty(logFileName))
                        return;
                    string? line;
                    long lineNumber = 0;

                    using FileStream fs = File.Open(Path.Combine(Constants.LogFolder, logFileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    using StreamReader sr = new StreamReader(fs, true);
                    while (!sr.EndOfStream) {
                        if ((line = sr.ReadLine()) != null) {
                            ++lineNumber;
                            if (lineNumber > lastReadLineNumber) {
                                OnRead?.Invoke(this, line);
                                lastReadLineNumber = lineNumber;
                            }
                        }
                    }
                }
            } catch (IOException io) {
                Console.WriteLine("LogReader.ReadLogFile:{0}{1}",
                    Environment.NewLine,
                    io);
                this.logWatcher.OnLogChange -= LogChange;
            }
        }
    }
}
