namespace EDHitchhiker.VanaheimSoftware.Utils
{
    class Constants
    {
        // todo - move out to where it is used. and remove this class

        private static readonly object lockObject = new();

        private static string logFolder = "";

        public static string LogFolder
        {
            get {
                lock (lockObject)
                {
                    if (logFolder == "")
                    {
                        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        string logPath = @"Saved Games\Frontier Developments\Elite Dangerous";
                        logFolder = Path.Combine(userPath, logPath);    
                    }
                    return logFolder;
                }
            }
        }

        public static string RouteFileName { get { return "NavRoute.json"; } }
        public static string LogFilePattern {  get { return "Journal.*-*-*.log"; } }

        public static double TimerInterval { get { return 500.0; } }
    }
}
