using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Deployment.Compression.Cab;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Diagnostics;

namespace Archiver.Model
{
    public class ArchiverModel : IArchiverModel
    {
        public void Archive(FileParametres dir)
        {
            try
            {
                if (dir.Level == CompressionLevel.Fastest.ToString())
                {
                    ZipFile.CreateFromDirectory($@"{dir.FilePath}", $@"{dir.ToArchivePath}.zip",
                        CompressionLevel.Fastest, dir.WithParent);
                } else if (dir.Level == CompressionLevel.Optimal.ToString())
                {
                    ZipFile.CreateFromDirectory($@"{dir.FilePath}", $@"{dir.ToArchivePath}.zip",
                        CompressionLevel.Optimal, dir.WithParent);
                } else if (dir.Level == CompressionLevel.NoCompression.ToString())
                {
                    ZipFile.CreateFromDirectory($@"{dir.FilePath}", $@"{dir.ToArchivePath}.zip",
                        CompressionLevel.NoCompression, dir.WithParent);
                }
            }
            catch { }
        }

        public FileSystemInfo[] GetContent(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            return info.GetFileSystemInfos();
        }

        public DriveInfo[] GetDrive()
        {
            return DriveInfo.GetDrives();
        }

        public void Open(string fileName)
        {
            ZipFile.Open(fileName, ZipArchiveMode.Read);
        }

        public void RemoveFile(string path)
        {
            File.Delete(path);
        }

        public void RemoveFolder(string path)
        {
            Directory.Delete(path, true);
        }

        public void Unzip(string fileName, string unzipTo)
        {
            ZipFile.ExtractToDirectory(fileName, unzipTo);
        }

        public void Start(string path)
        {
            Process.Start(path);
        }
    }
}
