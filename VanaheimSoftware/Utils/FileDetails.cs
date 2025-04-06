// Copyright (c) 2025, Erik Niese-Petersen
// All rights reserved.
//
// This source code is licensed under the BSD-style license found in the
// LICENSE.txt file in the root directory of this source tree.

namespace EDHitchhiker.VanaheimSoftware.Utils {
    class FileDetails
    {
        public static readonly string JOURNAL_FILE_CONVENTION = "Journal.*-*-*.log";
        public static readonly string ROUTE_FILE = "NavRoute.json";

        private const string JOURNAL_PATH = @"Saved Games\Frontier Developments\Elite Dangerous";

        private static readonly Object lockObject = new();

        private static string journalFolder = "";

        public static string JournalFolder
        {
            get {
                lock (lockObject)
                {
                    if (journalFolder == "")
                    {
                        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        journalFolder = Path.Combine(userPath, JOURNAL_PATH);    
                    }
                    return journalFolder;
                }
            }
        }
    }
}
