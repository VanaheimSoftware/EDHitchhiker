// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

using System.Timers;

namespace EDHitchhiker.VanaheimSoftware.Utils {
    public class JournalWatcher
    {
        private const double TIMER_INTERVAL = 500.0;

        private readonly Object lockObject = new();

        private string routeFile = "";
        private DateTime? routeLatest = DateTime.MinValue;
        private readonly System.Timers.Timer routeTimer = new System.Timers.Timer(TIMER_INTERVAL);

        private DateTime? journalLatest = DateTime.MinValue;
        private string journalFile = "";
        private readonly System.Timers.Timer journalTimer = new System.Timers.Timer(TIMER_INTERVAL);

        public event EventHandler? OnNewRoute;
        public event EventHandler<string>? OnJournalChange;

        public string CurrentJournalWatched
        {
            get
            {
                lock (lockObject)
                {
                    return journalFile;
                }
            }
        }

        public JournalWatcher()
        {
            InitializeRoute();
            InitializeJournal();
        }

        // Route handling
        private void InitializeRoute()
        {
            // todo - I could remove watching the Route file and instead trigger a read by the NavRoute Journal event
            routeFile = Path.Combine(FileDetails.JournalFolder, FileDetails.ROUTE_FILE);
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

        // Journal files handling
        private void InitializeJournal()
        {
            string[] journals = QueryJournalFiles();

            if (journals.Length > 0)
            {
                lock (lockObject) {
                    string last = journals.Last();
                    journalLatest = FileLastModified(last);
                    journalFile = Path.GetFileName(last);
                }
            }

            journalTimer.Elapsed += new ElapsedEventHandler(JournalTimerExecute);
            journalTimer.Start();
        }

        private static string[] QueryJournalFiles()
        {
            string[] journals = Directory.GetFiles(FileDetails.JournalFolder, FileDetails.JOURNAL_FILE_CONVENTION);
            Array.Sort(journals);

            return journals;
        }

        private void JournalTimerExecute(object? sender, ElapsedEventArgs e)
        {
            journalTimer.Stop();

            string[] journals = QueryJournalFiles();

            if (journals.Length > 0)
            {
                bool invoke = false;

                string last = journals.Last();
                DateTime latestWrite = FileLastModified(last);
                string fileName = Path.GetFileName(last);

                if (journalFile == fileName)
                {
                    if (latestWrite.CompareTo(journalLatest) > 0)
                    {
                        lock (lockObject)
                        {
                            journalLatest = latestWrite;
                            invoke = true;
                        }
                    }
                }
                else
                {
                    lock (lockObject)
                    {
                        journalFile = fileName;
                        journalLatest = latestWrite;
                    }
                    invoke = true;
                }

                if (invoke)
                {
                    string fileInvoke = "";
                    lock (lockObject)
                    {
                        fileInvoke = journalFile;
                    }
                    OnJournalChange?.Invoke(this, fileInvoke);
                    
                }
            }

            journalTimer.Start();
        }
    }
}
