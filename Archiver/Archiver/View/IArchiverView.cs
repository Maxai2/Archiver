using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.View
{
    interface IArchiverView
    {
        event EventHandler<EventArgs> LoadDisks;
        event EventHandler<PathEventArgs> LoadConent;
        event EventHandler<PathEventArgs> Open;
        event EventHandler<PathEventArgs> RemoveFolder;
        event EventHandler<PathEventArgs> RemoveFile;
        event EventHandler<DirItemEventArgs> Archiving;
        event EventHandler<PathEventArgs> Unzipping;
        event EventHandler<PathEventArgs> UnzipHere;
        event EventHandler<PathEventArgs> OpenZip;
        event EventHandler<PathEventArgs> OpenFile;
        string GetFolderPath();
        FileParametres ArchivingWindow(string fullPath, string name, string parent);
        void ShowDisks(DriveInfo[] drives);
        void ShowContent(FileSystemInfo[] content);
    }
}
