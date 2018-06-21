using System;

namespace Archiver.View {
    public class PathEventArgs : EventArgs {
        public PathEventArgs(string path) {
            Path = path;
        }

        public PathEventArgs(string fileName, string path) {
            FileName = fileName;
            Path = path;
        }

        public string FileName { get; set; }
        public string Path { get; set; }
    }
}