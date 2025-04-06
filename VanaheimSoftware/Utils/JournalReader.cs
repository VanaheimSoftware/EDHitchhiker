// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.Diagnostics;

namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class JournalReader {
        private readonly Object locker = new();

        private readonly JournalWatcher journalWatcher;
        private string journalFileName;
        private long lastReadLineNumber = 0;

        public event EventHandler<string>? OnRead;

        public JournalReader(JournalWatcher watcher) {
            journalWatcher = watcher;
            journalFileName = journalWatcher.CurrentJournalWatched;
            CalculateLines();

            this.journalWatcher.OnNewRoute += NewRoute;
            this.journalWatcher.OnJournalChange += LogChange;
        }

        ~JournalReader() {
            this.journalWatcher.OnNewRoute -= NewRoute;
            this.journalWatcher.OnJournalChange -= LogChange;
        }


        public void ReloadRoute() {
            NewRoute(this, new());
        }

        private void NewRoute(object? sender, EventArgs e) {
            try {
                using FileStream fs = File.Open(Path.Combine(FileDetails.JournalFolder, FileDetails.ROUTE_FILE), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using StreamReader sr = new(fs, true);
                string data = sr.ReadToEnd();
                if (!String.IsNullOrEmpty(data)) {
                    OnRead?.Invoke(this, data);
                }
            } catch (IOException io) {
                Debug.WriteLine("LogReader.NewRoute:{0}{1}",
                    Environment.NewLine,
                    io);
                this.journalWatcher.OnNewRoute -= NewRoute;
            }
        }

        private void LogChange(object? sender, string logFile) {
            string currentLogFile = this.journalWatcher.CurrentJournalWatched;
            if (currentLogFile != journalFileName) {
                ReadLogFile();  // Finish current up, if need to
                lock (locker) {
                    journalFileName = currentLogFile;
                    lastReadLineNumber = 0;
                }
            }
            ReadLogFile();
        }



        private void CalculateLines() {
            lock (locker) {
                if (String.IsNullOrEmpty(journalFileName))
                    return;
                string? line;
                long lineNumber = 0;
                using FileStream fs = File.Open(Path.Combine(FileDetails.JournalFolder, journalFileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using StreamReader sr = new(fs, true);
                while (!sr.EndOfStream && (line = sr.ReadLine()) != null) {
                    ++lineNumber;
                }

                lastReadLineNumber = lineNumber;
            }
        }

        private void ReadLogFile() {
            try {
                lock (locker) {
                    if (String.IsNullOrEmpty(journalFileName))
                        return;
                    string? line;
                    long lineNumber = 0;

                    using FileStream fs = File.Open(Path.Combine(FileDetails.JournalFolder, journalFileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
                Debug.WriteLine("LogReader.ReadLogFile:{0}{1}",
                    Environment.NewLine,
                    io);
                this.journalWatcher.OnJournalChange -= LogChange;
            }
        }
    }
}
