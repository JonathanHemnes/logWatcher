using System;
using System.Collections.Generic;
using System.IO;

namespace logWatcher
{
    public class Parser
    {
        private string _logLocation;
        public int ErrorCount { private get; set; }
        public int WarnCount { private get; set; }
        private readonly List<string> _errorList = new List<string>();
        private readonly List<string> _warnList = new List<string>();

        public Parser(string logLocation)
        {
            _logLocation = logLocation;
        }

        public void PrintFile()
        {
  
            StreamReader sr = new StreamReader(_logLocation);
            string line = sr.ReadToEnd();
            Console.WriteLine(line);
            sr.Close();
        }
        public void SetErrors()
        {

            using (var stream = File.Open(_logLocation,FileMode.Open,FileAccess.Read,FileShare.ReadWrite))
            using(var reader = new StreamReader(stream))
            {               
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.Contains("ERROR")) continue;
                    if (_errorList.Contains(line)) continue;
                    _errorList.Add(line);
                    ErrorCount++;
                }
            }
        }

        public void SetWarnings()
        {
            using (var stream = File.Open(_logLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.Contains("WARN")) continue;
                    if (_warnList.Contains(line)) continue;
                    _warnList.Add(line);
                    WarnCount++;
                }
            }
        }
        public int GetErrorCount()
        {
            return ErrorCount;
        }
        public int GetWarnCount()
        {
            return WarnCount;
        }
        public void SetLogLocation(string logLocation)
        {
      
           _logLocation = logLocation;

        }
        public List<string> GetWarningMessages()
        {
            return _warnList;
        }
        public List<string> GetErrorMessages()
        {
            return _errorList;
        }
    }
}
