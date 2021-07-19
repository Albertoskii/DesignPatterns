using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        // just a counter for total # of entries
        private static int count = 0;
        public void AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        /// <summary>
        /// his approach is problematic. The journal's responsibility is to keep journal entries, 
        /// not to write them to disk. If you add the persistence functionality to Journal and similar classes, 
        /// any change in the approach to persistence (say, you decide to write to the cloud instead of disk) 
        /// would require lots of tiny changes in each of the affected classes.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="overwrite"></param>
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
    }
}
