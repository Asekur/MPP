using System;
using System.Collections.Generic;
using System.IO;

namespace Pool_Thread
{
    class FileCopy
    {
        private static int _amountDirectories = 0;
        private static int _amountCopiedFiles = 0;
        public static List<string> pathSourceFiles = new List<string>();
        public static void StartCopy(string source, string dest, string file)
        {
            if (_amountDirectories != 0)
            {
                Directory.CreateDirectory(file.Replace(source, dest));
                _amountDirectories--;
            }
            else
            {
                string fileName = file.Replace(source, dest);
                File.Copy(file, fileName, true);
            }
            _amountCopiedFiles++;
        }

        public static List<string> GetAmountInSource(string source)
        {
            IEnumerable<string> allfiles = Directory.EnumerateFiles(source, "*.*", SearchOption.AllDirectories);
            IEnumerable<string> allfolders = Directory.EnumerateDirectories(source, "*.*", SearchOption.AllDirectories);
            //add all directories to list
            foreach (string folder in allfolders)
            {
                pathSourceFiles.Add(folder);
                _amountDirectories++;
            }
            //add all files to list
            foreach (string filename in allfiles)
            {
                pathSourceFiles.Add(filename);
            }
            return pathSourceFiles;
        }

        public static int GetResultAmount()
        {
            return _amountCopiedFiles;
        }
    }
}
