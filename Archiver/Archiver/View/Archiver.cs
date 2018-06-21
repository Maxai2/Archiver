using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver.View
{
    public partial class Archiver : Form, IArchiverView
    {
        private Stack<string> FullPath;
        FileSystemWatcher cheker;
        SynchronizationContext context;
        public Archiver()
        {
            InitializeComponent();
            FullPath = new Stack<string>();
            access_strip.ImageList = new ImageList() { ImageSize = new Size(50, 50) };
            content_View.LargeImageList = content_View.SmallImageList = new ImageList() {
                Images = { },
                ColorDepth = ColorDepth.Depth32Bit,
                ImageSize = new Size(50, 50)
            };
            fullpath_lbl.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            context = SynchronizationContext.Current;
            cheker = new FileSystemWatcher();
            cheker.Path = fullpath_lbl.Text;
            cheker.EnableRaisingEvents = true;
            cheker.Created += (s, e) => {
                context.Post(val => Cheker_Created(s, e), s);
            };
            cheker.Deleted += (s, e) => {
                context.Post(value => Cheker_Deleted(s, e), s);
            };
            cheker.Renamed += (s, e) => {
                context.Post(value => Cheker_Renamed(s, e), s);
            };
            back_btn.Enabled = false;
        }

        private void Cheker_Renamed(object sender, RenamedEventArgs e)
        {
            Update(e.FullPath.Replace(e.Name, String.Empty));
        }

        private void Cheker_Deleted(object sender, FileSystemEventArgs e)
        {
            Update(e.FullPath.Replace(e.Name, String.Empty));
        }

        public event EventHandler<DirItemEventArgs> Archiving;
        public event EventHandler<PathEventArgs> RemoveFolder;
        public event EventHandler<EventArgs> LoadDisks;
        public event EventHandler<PathEventArgs> LoadConent;
        public event EventHandler<PathEventArgs> Open;
        public event EventHandler<PathEventArgs> RemoveFile;
        public event EventHandler<PathEventArgs> Unzipping;
        public event EventHandler<PathEventArgs> UnzipHere;
        public event EventHandler<PathEventArgs> OpenZip;
        public event EventHandler<PathEventArgs> OpenFile;

        public void ShowContent(FileSystemInfo[] content)
        {
            content_View.Items.Clear();
            content_View.LargeImageList.Images.Clear();
            content_View.LargeImageList.Images.Add("Folder",
                                                Image.FromFile("../../FolderIcon.png"));
            int n = 0;
            foreach (FileSystemInfo item in content)
            {
                if (item is DirectoryInfo dir)
                {
                    var folder = content_View.Items.Add(dir.Name, dir.Name, "Folder");
                    folder.ImageKey = "Folder";
                    folder.Tag = dir;
                }
                if (item is FileInfo file)
                {
                    var fileIcon = Icon.ExtractAssociatedIcon(file.FullName);
                    content_View.LargeImageList.Images.Add($"File{n.ToString()}", fileIcon);
                    var fil = content_View.Items.Add(file.Name, file.Name, $"File{n.ToString()}");
                    fil.Tag = file;
                    n++;
                }
            }
        }

        public void ShowDisks(DriveInfo[] drives)
        {
            foreach (DriveInfo drive in drives)
            {
                var item = access_strip.Items.Add(drive.Name, Image.FromFile("../../DriveIcon.png"));
                item.ImageAlign = ContentAlignment.MiddleLeft;
                item.Tag = drive;
            }
        }

        private void Archiver_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            LoadDisks.Invoke(this, EventArgs.Empty);
            fullpath_lbl.Text = path;
            Open.Invoke(this, new PathEventArgs(path));
        }

        private void access_strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                FullPath.Clear();
            }
            catch { }
            back_btn.Enabled = false;
            var dekstop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var myDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (access_strip.Items[1].Selected == true)
            {
                LoadConent.Invoke(this, new PathEventArgs(dekstop));
                fullpath_lbl.Text = dekstop;
                cheker.Path = fullpath_lbl.Text;
            } else if (access_strip.Items[2].Selected == true)
            {
                fullpath_lbl.Text = myDoc;
                cheker.Path = fullpath_lbl.Text;
                LoadConent.Invoke(this, new PathEventArgs(myDoc));
            } else
            {
                try
                {
                    fullpath_lbl.Text = e.ClickedItem.Text;
                    cheker.Path = fullpath_lbl.Text;
                    LoadConent.Invoke(this, new PathEventArgs(e.ClickedItem.Text));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            fullpath_lbl.Text = FullPath.Peek();
            cheker.Path = fullpath_lbl.Text;
            LoadConent.Invoke(this, new PathEventArgs(FullPath.Pop()));
            if (FullPath.Count == 0)
            {
                back_btn.Enabled = false;
            }
        }

        private void content_View_MouseClick(object sender, MouseEventArgs e)
        {
            var item = content_View.FocusedItem;
            if (e.Button == MouseButtons.Right)
            {
                if (item.Bounds.Contains(e.Location) == true)
                {
                    if (item.Tag is DirectoryInfo dir)
                    {
                        folder_Contex.Show(Cursor.Position);
                        folder_Contex.ItemClicked += ItemClick;
                    } else if (item.Tag is FileInfo file &&
                              (file.Extension != ".rar" &&
                              file.Extension != ".zip"))
                    {
                        fileContex.Show(Cursor.Position);
                        fileContex.ItemClicked += FileContex_ItemClicked;
                    } else if (item.Tag is FileInfo archive &&
                              (archive.Extension == ".rar" ||
                              archive.Extension == ".zip"))
                    {
                        zipContex.Show(Cursor.Position);
                        zipContex.ItemClicked += ZipContex_ItemClicked;
                    }
                }
            }
        }

        private void ZipContex_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (content_View.SelectedItems[0].Tag is FileInfo archive)
            {
                if (zipContex.Items[0].Pressed == true)
                {
                    zipContex.Hide();
                    OpenZip.Invoke(this,
                    new PathEventArgs(archive.FullName));
                } else if (zipContex.Items[1].Pressed == true)
                {
                    zipContex.Hide();
                    try
                    {
                        UnzipHere.Invoke(this, new PathEventArgs(archive.FullName, archive.DirectoryName));
                    }
                    catch { }
                } else if (zipContex.Items[2].Pressed == true)
                {
                    zipContex.Hide();
                    try
                    {
                        Unzipping.Invoke(this, new PathEventArgs(archive.FullName));
                    }
                    catch { }
                } else if (zipContex.Items[3].Pressed == true)
                {
                    zipContex.Hide();
                    try
                    {
                        RemoveFile.Invoke(this, new PathEventArgs(archive.FullName));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void FileContex_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (content_View.SelectedItems[0].Tag is FileInfo file)
            {
                if (fileContex.Items[1].Pressed == true)
                {
                    fileContex.Hide();
                    try
                    {
                        RemoveFile.Invoke(this, new PathEventArgs(file.FullName));
                    }
                    catch { }
                } else if (fileContex.Items[0].Pressed == true)
                {
                    fileContex.Hide();
                    if (content_View.SelectedItems[0].Tag is FileInfo fil &&
                                       (fil.Extension != ".rar" &&
                                       fil.Extension != ".zip"))
                    {
                        OpenFile.Invoke(this, new PathEventArgs(fil.FullName));
                    }

                } else if (fileContex.Items[0].Pressed == true)
                {
                    fileContex.Hide();
                    if (content_View.SelectedItems[0].Tag is FileInfo archive &&
                                    (archive.Extension == ".rar" ||
                                    archive.Extension == ".zip"))
                    {
                        OpenZip.Invoke(this,
                    new PathEventArgs(archive.FullName));
                    }
                }
            }
        }

        private void ItemClick(object sender, EventArgs e)
        {
            try
            {
                if (content_View.SelectedItems[0].Tag is DirectoryInfo dir)
                {
                    string path = dir.FullName.Replace(dir.Name, String.Empty);
                    if (folder_Contex.Items[0].Pressed == true)
                    {
                        folder_Contex.Hide();
                        RemoveFolder.Invoke(this, new PathEventArgs(dir.FullName));
                    } else if (folder_Contex.Items[1].Pressed == true)
                    {
                        folder_Contex.Hide();
                        Archiving.Invoke(this, new DirItemEventArgs(dir.FullName, dir.Name, dir.Parent.FullName));
                    }
                }
            }
            catch { }
        }

        public FileParametres ArchivingWindow(string fullName, string name, string parent)
        {

            ArchivateSettings archivateSettings = new ArchivateSettings();
            archivateSettings.Parametres.FilePath = fullName;
            archivateSettings.Parametres.FileName = name;
            archivateSettings.Parametres.FileParent = parent;
            archivateSettings.ShowDialog();
            var result = archivateSettings.DialogResult;
            if (result == DialogResult.OK)
            {
                content_View.Refresh();
                return archivateSettings.Parametres;
            } else { return null; }
        }

        private void content_View_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    FullPath.Push(fullpath_lbl.Text);
                    if (FullPath.Count != 0)
                    {
                        back_btn.Enabled = true;
                    }
                    if (content_View.SelectedItems[0].Tag is DirectoryInfo dir)
                    {
                        if (dir.Exists == true)
                        {
                            fullpath_lbl.Text = dir.FullName;
                            cheker.Path = fullpath_lbl.Text;
                            Open.Invoke(this, new PathEventArgs(dir.FullName));
                        }
                    } else if (content_View.SelectedItems[0].Tag is FileInfo file &&
                                  (file.Extension != ".rar" &&
                                  file.Extension != ".zip"))
                    {
                        OpenFile.Invoke(this, new PathEventArgs(file.FullName));
                    } else if (content_View.SelectedItems[0].Tag is FileInfo archive &&
                                  (archive.Extension == ".rar" ||
                                  archive.Extension == ".zip"))
                    {
                        OpenZip.Invoke(this,
                    new PathEventArgs(archive.FullName));
                    }
                }
                catch
                {
                    fullpath_lbl.Text = FullPath.Pop();
                    cheker.Path = fullpath_lbl.Text;
                }
            }
        }

        private void Cheker_Created(object sender, FileSystemEventArgs e)
        {
            Update(e.FullPath.Replace(e.Name, String.Empty));
        }

        public string GetFolderPath()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                return folder.SelectedPath;
            } else { return null; }
        }

        public void Update(string name)
        {
            content_View.Items.Clear();
            DirectoryInfo info = new DirectoryInfo(name);
            var content = info.GetFileSystemInfos();
            ShowContent(content);
        }
    }
}