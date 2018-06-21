using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiver.View
{
    public partial class ArchivateSettings : Form
    {
        public FileParametres Parametres { get; set; }

        public ArchivateSettings()
        {
            InitializeComponent();
            cancel_btn.DialogResult = DialogResult.Cancel;
            string[] cont = { CompressionLevel.NoCompression.ToString(), CompressionLevel.Fastest.ToString(), CompressionLevel.Optimal.ToString() };
            compr_Box.DataSource = cont;
            Parametres = new FileParametres();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (path_Box.Text != String.Empty)
            {
                Parametres.Level = compr_Box.SelectedItem as string;
                Parametres.ToArchivePath = path_Box.Text.Replace(".zip", String.Empty);
            }
            DialogResult = DialogResult.OK;
        }

        private void sel_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                Parametres.ToArchivePath = $@"{folder.SelectedPath}\{Parametres.FileName}";
                path_Box.Text = $@"{Parametres.ToArchivePath}.zip";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Parametres.WithParent = true;
            }
            else
            {
                Parametres.WithParent = false;
            }
        }

        private void ArchivateSettings_Load(object sender, EventArgs e)
        {
            path_Box.Text = $@"{Parametres.FilePath}.zip";
            Parametres.WithParent = false;
        }
    }
}

public class FileParametres
{
    public string ToArchivePath { get; set; }
    public string FileName { get; set; }
    public string Level { get; set; }
    public bool WithParent { get; set; }
    public string FilePath { get; set; }
    public string FileParent { get; set; }
}