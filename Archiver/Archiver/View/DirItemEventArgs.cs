using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.View
{
    public class DirItemEventArgs : EventArgs
    {
        public DirItemEventArgs(string fullPath, string name, string parent)
        {
            FullPath = fullPath;
            Name = name;
            Parent = parent;
        }

        public string FullPath { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }

    }
}
