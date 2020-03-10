namespace BigSoft.Framework.Controls
{
    sealed partial class BsStandartToolStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BsStandartToolStrip));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbGet = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGet,
            this.tsbSearch,
            this.tsbSave,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbClear,
            this.tsbExit,
            this.tsbRefresh});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(695, 31);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // tsbGet
            // 
            this.tsbGet.Image = ((System.Drawing.Image)(resources.GetObject("tsbGet.Image")));
            this.tsbGet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGet.Name = "tsbGet";
            this.tsbGet.Size = new System.Drawing.Size(60, 28);
            this.tsbGet.Text = "Getir";
            this.tsbGet.Click += new System.EventHandler(this.TsbGet_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(53, 28);
            this.tsbSearch.Text = "Ara";
            this.tsbSearch.Visible = false;
            this.tsbSearch.Click += new System.EventHandler(this.TsbSearch_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(71, 28);
            this.tsbSave.Text = "Kaydet";
            this.tsbSave.Click += new System.EventHandler(this.TsbSave_Click_1);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(81, 28);
            this.tsbUpdate.Text = "Güncelle";
            this.tsbUpdate.Click += new System.EventHandler(this.TsbUpdate_Click_1);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(47, 28);
            this.tsbDelete.Text = "Sil";
            this.tsbDelete.Click += new System.EventHandler(this.TsbDelete_Click_1);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(76, 28);
            this.tsbClear.Text = "Temizle";
            this.tsbClear.Click += new System.EventHandler(this.TsbClear_Click_1);
            // 
            // tsbExit
            // 
            this.tsbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(65, 28);
            this.tsbExit.Text = "Kapat";
            this.tsbExit.Click += new System.EventHandler(this.TsbExit_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(59, 28);
            this.tsbRefresh.Text = "Yenile";
            this.tsbRefresh.Visible = false;
            this.tsbRefresh.Click += new System.EventHandler(this.TsbRefresh_Click);
            // 
            // OkStandartToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OkStandartToolStrip";
            this.Size = new System.Drawing.Size(695, 31);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        public System.Windows.Forms.ToolStripButton tsbGet;
        public System.Windows.Forms.ToolStripButton tsbSearch;
        public System.Windows.Forms.ToolStripButton tsbSave;
        public System.Windows.Forms.ToolStripButton tsbUpdate;
        public System.Windows.Forms.ToolStripButton tsbDelete;
        public System.Windows.Forms.ToolStripButton tsbClear;
        public System.Windows.Forms.ToolStripButton tsbExit;
        public System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}
