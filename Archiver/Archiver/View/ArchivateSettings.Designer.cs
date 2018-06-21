namespace Archiver.View
{
    partial class ArchivateSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivateSettings));
            this.archPath_lbl = new System.Windows.Forms.Label();
            this.path_Box = new System.Windows.Forms.TextBox();
            this.sel_Btn = new System.Windows.Forms.Button();
            this.compr_lbl = new System.Windows.Forms.Label();
            this.compr_Box = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // archPath_lbl
            // 
            this.archPath_lbl.AutoSize = true;
            this.archPath_lbl.Location = new System.Drawing.Point(12, 30);
            this.archPath_lbl.Name = "archPath_lbl";
            this.archPath_lbl.Size = new System.Drawing.Size(91, 13);
            this.archPath_lbl.TabIndex = 0;
            this.archPath_lbl.Text = "Path to archivate:";
            // 
            // path_Box
            // 
            this.path_Box.Location = new System.Drawing.Point(13, 47);
            this.path_Box.Multiline = true;
            this.path_Box.Name = "path_Box";
            this.path_Box.Size = new System.Drawing.Size(340, 72);
            this.path_Box.TabIndex = 1;
            // 
            // sel_Btn
            // 
            this.sel_Btn.Location = new System.Drawing.Point(15, 125);
            this.sel_Btn.Name = "sel_Btn";
            this.sel_Btn.Size = new System.Drawing.Size(338, 23);
            this.sel_Btn.TabIndex = 2;
            this.sel_Btn.Text = "Choose path";
            this.sel_Btn.UseVisualStyleBackColor = true;
            this.sel_Btn.Click += new System.EventHandler(this.sel_Btn_Click);
            // 
            // compr_lbl
            // 
            this.compr_lbl.AutoSize = true;
            this.compr_lbl.Location = new System.Drawing.Point(12, 182);
            this.compr_lbl.Name = "compr_lbl";
            this.compr_lbl.Size = new System.Drawing.Size(95, 13);
            this.compr_lbl.TabIndex = 0;
            this.compr_lbl.Text = "Compression level:";
            // 
            // compr_Box
            // 
            this.compr_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compr_Box.FormattingEnabled = true;
            this.compr_Box.Location = new System.Drawing.Point(13, 199);
            this.compr_Box.Name = "compr_Box";
            this.compr_Box.Size = new System.Drawing.Size(340, 21);
            this.compr_Box.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "With parent directory";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(11, 280);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(168, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(185, 280);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(168, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // ArchivateSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 323);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.compr_Box);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.sel_Btn);
            this.Controls.Add(this.path_Box);
            this.Controls.Add(this.compr_lbl);
            this.Controls.Add(this.archPath_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 362);
            this.MinimumSize = new System.Drawing.Size(381, 362);
            this.Name = "ArchivateSettings";
            this.ShowInTaskbar = false;
            this.Text = "ArchivateSettings";
            this.Load += new System.EventHandler(this.ArchivateSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label archPath_lbl;
        private System.Windows.Forms.TextBox path_Box;
        private System.Windows.Forms.Button sel_Btn;
        private System.Windows.Forms.Label compr_lbl;
        private System.Windows.Forms.ComboBox compr_Box;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
    }
}