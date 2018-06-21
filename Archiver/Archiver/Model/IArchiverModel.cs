using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Archiver.Model
{
    interface IArchiverModel
    {
        DriveInfo[] GetDrive();
        FileSystemInfo[] GetContent(string path);
        void RemoveFolder(string path);
        void Archive(FileParametres settings);
        void RemoveFile(string path);
        void Unzip(string fileName, string unzipTo);
        void Open(string fileName);
        void Start(string path);
    }
}
