namespace Archiver.View
{
    partial class Archiver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archiver));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back_btn = new System.Windows.Forms.ToolStripButton();
            this.path_lbl = new System.Windows.Forms.ToolStripLabel();
            this.fullpath_lbl = new System.Windows.Forms.ToolStripLabel();
            this.access_strip = new System.Windows.Forms.ToolStrip();
            this.acsess_lbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.content_View = new System.Windows.Forms.ListView();
            this.folder_Contex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipContex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileContex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.access_strip.SuspendLayout();
            this.folder_Contex.SuspendLayout();
            this.zipContex.SuspendLayout();
            this.fileContex.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_btn,
            this.path_lbl,
            this.fullpath_lbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1239, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // back_btn
            // 
            this.back_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(23, 22);
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // path_lbl
            // 
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(59, 22);
            this.path_lbl.Text = "Full path: ";
            // 
            // fullpath_lbl
            // 
            this.fullpath_lbl.Name = "fullpath_lbl";
            this.fullpath_lbl.Size = new System.Drawing.Size(22, 22);
            this.fullpath_lbl.Text = "     ";
            // 
            // access_strip
            // 
            this.access_strip.Dock = System.Windows.Forms.DockStyle.Left;
            this.access_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acsess_lbl,
            this.toolStripButton1,
            this.toolStripButton2});
            this.access_strip.Location = new System.Drawing.Point(0, 25);
            this.access_strip.Name = "access_strip";
            this.access_strip.Size = new System.Drawing.Size(109, 610);
            this.access_strip.TabIndex = 1;
            this.access_strip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.access_strip_ItemClicked);
            // 
            // acsess_lbl
            // 
            this.acsess_lbl.Enabled = false;
            this.acsess_lbl.Name = "acsess_lbl";
            this.acsess_lbl.Size = new System.Drawing.Size(106, 15);
            this.acsess_lbl.Text = "Quick acsess:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 20);
            this.toolStripButton1.Text = "Dekstop";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(106, 20);
            this.toolStripButton2.Text = "My Documents";
            // 
            // content_View
            // 
            this.content_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_View.Location = new System.Drawing.Point(109, 25);
            this.content_View.Name = "content_View";
            this.content_View.Size = new System.Drawing.Size(1130, 610);
            this.content_View.TabIndex = 2;
            this.content_View.UseCompatibleStateImageBehavior = false;
            this.content_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.content_View_MouseClick);
            this.content_View.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.content_View_MouseDoubleClick);
            // 
            // folder_Contex
            // 
            this.folder_Contex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.folder_Contex.Name = "contextMenuStrip1";
            this.folder_Contex.Size = new System.Drawing.Size(115, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.removeToolStripMenuItem.Text = "Delete";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // zipContex
            // 
            this.zipContex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.unzipToolStripMenuItem,
            this.unzipToToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.zipContex.Name = "zipContex";
            this.zipContex.Size = new System.Drawing.Size(131, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // unzipToolStripMenuItem
            // 
            this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            this.unzipToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.unzipToolStripMenuItem.Text = "Unzip here";
            // 
            // unzipToToolStripMenuItem
            // 
            this.unzipToToolStripMenuItem.Name = "unzipToToolStripMenuItem";
            this.unzipToToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.unzipToToolStripMenuItem.Text = "Unzip to...";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // fileContex
            // 
            this.fileContex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.deleteToolStripMenuItem2});
            this.fileContex.Name = "fileContex";
            this.fileContex.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Open";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            // 
            // Archiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 635);
            this.Controls.Add(this.content_View);
            this.Controls.Add(this.access_strip);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1255, 674);
            this.Name = "Archiver";
            this.Text = "Archiver";
            this.Load += new System.EventHandler(this.Archiver_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.access_strip.ResumeLayout(false);
            this.access_strip.PerformLayout();
            this.folder_Contex.ResumeLayout(false);
            this.zipContex.ResumeLayout(false);
            this.fileContex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back_btn;
        private System.Windows.Forms.ToolStripLabel path_lbl;
        private System.Windows.Forms.ToolStrip access_strip;
        private System.Windows.Forms.ToolStripLabel acsess_lbl;
        private System.Windows.Forms.ListView content_View;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel fullpath_lbl;
        private System.Windows.Forms.ContextMenuStrip folder_Contex;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip zipContex;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fileContex;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
    }
}