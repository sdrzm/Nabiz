namespace BigSoft.Framework.Controls
{
    partial class BsFormGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.BsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BsPanelTop = new System.Windows.Forms.Panel();
            this.BsPanelFill = new System.Windows.Forms.Panel();
            this.BsAdgv = new BigSoft.Framework.Controls.BsAdvDataGridView();
            this.BsStandartToolStrip = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.BsStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BsStatusStrip
            // 
            this.BsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BsToolStripStatusLabel});
            this.BsStatusStrip.Location = new System.Drawing.Point(0, 439);
            this.BsStatusStrip.Name = "BsStatusStrip";
            this.BsStatusStrip.Size = new System.Drawing.Size(884, 22);
            this.BsStatusStrip.TabIndex = 3;
            this.BsStatusStrip.Text = "BsStatusStrip";
            // 
            // BsToolStripStatusLabel
            // 
            this.BsToolStripStatusLabel.Name = "BsToolStripStatusLabel";
            this.BsToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.BsToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // BsBindingSource
            // 
            this.BsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BsBindingSource_ListChanged);
            // 
            // BsPanelTop
            // 
            this.BsPanelTop.Controls.Add(this.BsStandartToolStrip);
            this.BsPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BsPanelTop.Location = new System.Drawing.Point(0, 0);
            this.BsPanelTop.Name = "BsPanelTop";
            this.BsPanelTop.Size = new System.Drawing.Size(884, 173);
            this.BsPanelTop.TabIndex = 4;
            // 
            // BsPanelFill
            // 
            this.BsPanelFill.Controls.Add(this.BsAdgv);
            this.BsPanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BsPanelFill.Location = new System.Drawing.Point(0, 173);
            this.BsPanelFill.Name = "BsPanelFill";
            this.BsPanelFill.Size = new System.Drawing.Size(884, 266);
            this.BsPanelFill.TabIndex = 5;
            // 
            // BsAdgv
            // 
            this.BsAdgv.AllowUserToAddRows = false;
            this.BsAdgv.AllowUserToDeleteRows = false;
            this.BsAdgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BsAdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BsAdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BsAdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BsAdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BsAdgv.FilterAndSortEnabled = true;
            this.BsAdgv.Location = new System.Drawing.Point(0, 0);
            this.BsAdgv.MultiSelect = false;
            this.BsAdgv.Name = "BsAdgv";
            this.BsAdgv.ReadOnly = true;
            this.BsAdgv.RowHeadersVisible = false;
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BsAdgv.Size = new System.Drawing.Size(884, 266);
            this.BsAdgv.TabIndex = 1;
            // 
            // BsStandartToolStrip
            // 
            this.BsStandartToolStrip.AutoSize = true;
            this.BsStandartToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.BsStandartToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BsStandartToolStrip.Margin = new System.Windows.Forms.Padding(2);
            this.BsStandartToolStrip.Name = "BsStandartToolStrip";
            this.BsStandartToolStrip.Size = new System.Drawing.Size(884, 31);
            this.BsStandartToolStrip.TabIndex = 2;
            // 
            // BsFormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.BsPanelFill);
            this.Controls.Add(this.BsPanelTop);
            this.Controls.Add(this.BsStatusStrip);
            this.Name = "BsFormGrid";
            this.Text = "BsFormGrid";
            this.BsStatusStrip.ResumeLayout(false);
            this.BsStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).EndInit();
            this.BsPanelTop.ResumeLayout(false);
            this.BsPanelTop.PerformLayout();
            this.BsPanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip BsStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel BsToolStripStatusLabel;
        protected BsStandartToolStrip BsStandartToolStrip;
        protected BsAdvDataGridView BsAdgv;
        protected System.Windows.Forms.BindingSource BsBindingSource;
        protected System.Windows.Forms.Panel BsPanelTop;
        protected System.Windows.Forms.Panel BsPanelFill;
    }
}