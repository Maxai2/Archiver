using Archiver.Model;
using Archiver.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Presenter {
    class ArchiverPresenter {
        private View.Archiver archiverView;
        private IArchiverModel archiverModel;
        public ArchiverPresenter(View.Archiver archiverView, IArchiverModel archiverModel) {
            this.archiverView = archiverView;
            this.archiverModel = archiverModel;

            archiverView.LoadDisks += ArchiverView_LoadDisks;
            archiverView.LoadConent += ArchiverView_LoadConent;
            archiverView.Open += ArchiverView_Open;
            archiverView.RemoveFolder += ArchiverView_RemoveFolder;
            archiverView.Archiving += ArchiverView_Archiving;
            archiverView.RemoveFile += ArchiverView_RemoveFile;
            archiverView.Unzipping += ArchiverView_Unzipping;
            archiverView.UnzipHere += ArchiverView_UnzipHere;
            archiverView.OpenFile += ArchiverView_OpenFile;
            archiverView.OpenZip += ArchiverView_OpenZip;
        }

        private void ArchiverView_OpenZip(object sender, PathEventArgs e) {
            archiverModel.Start(e.Path);
        }

        private void ArchiverView_OpenFile(object sender, PathEventArgs e) {
            archiverModel.Start(e.Path);
        }

        private void ArchiverView_UnzipHere(object sender, PathEventArgs e) {
            archiverModel.Unzip(e.FileName, e.Path);
        }

        private void ArchiverView_Unzipping(object sender, PathEventArgs e) {
            archiverModel.Unzip(e.Path, archiverView.GetFolderPath());
        }

        private void ArchiverView_RemoveFile(object sender, PathEventArgs e) {
            archiverModel.RemoveFile(e.Path);
        }

        private void ArchiverView_Archiving(object sender, DirItemEventArgs e) {
            archiverModel.Archive(archiverView.ArchivingWindow(e.FullPath, e.Name, e.Parent));
        }

        private void ArchiverView_RemoveFolder(object sender, PathEventArgs e) {
            archiverModel.RemoveFolder(e.Path);
        }

        private void ArchiverView_Open(object sender, PathEventArgs e) {
            archiverView.ShowContent(archiverModel.GetContent(e.Path));
        }

        private void ArchiverView_LoadConent(object sender, PathEventArgs e) {
            archiverView.ShowContent(archiverModel.GetContent(e.Path));
        }

        private void ArchiverView_LoadDisks(object sender, EventArgs e) {
            archiverView.ShowDisks(archiverModel.GetDrive());
        }
    }
}
