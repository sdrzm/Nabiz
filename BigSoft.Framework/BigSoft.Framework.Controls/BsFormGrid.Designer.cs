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
            this.BsStandartToolStrip = new BigSoft.Framework.Controls.BsStandartToolStrip();
            this.BsPanelFill = new System.Windows.Forms.Panel();
            this.BsAdgv = new BigSoft.Framework.Controls.BsAdvDataGridView();
            this.BsStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BsStatusStrip
            // 
            this.BsStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BsToolStripStatusLabel});
            this.BsStatusStrip.Location = new System.Drawing.Point(0, 541);
            this.BsStatusStrip.Name = "BsStatusStrip";
            this.BsStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.BsStatusStrip.Size = new System.Drawing.Size(1179, 26);
            this.BsStatusStrip.TabIndex = 3;
            this.BsStatusStrip.Text = "BsStatusStrip";
            // 
            // BsToolStripStatusLabel
            // 
            this.BsToolStripStatusLabel.Name = "BsToolStripStatusLabel";
            this.BsToolStripStatusLabel.Size = new System.Drawing.Size(151, 20);
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
            this.BsPanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.BsPanelTop.Name = "BsPanelTop";
            this.BsPanelTop.Size = new System.Drawing.Size(1179, 213);
            this.BsPanelTop.TabIndex = 4;
            // 
            // BsStandartToolStrip
            // 
            this.BsStandartToolStrip.AutoSize = true;
            this.BsStandartToolStrip.BsDeleteButtonEnabled = true;
            this.BsStandartToolStrip.BsSaveButtonEnabled = true;
            this.BsStandartToolStrip.BsUpdateButtonEnabled = false;
            this.BsStandartToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.BsStandartToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BsStandartToolStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BsStandartToolStrip.Name = "BsStandartToolStrip";
            this.BsStandartToolStrip.Size = new System.Drawing.Size(1179, 31);
            this.BsStandartToolStrip.TabIndex = 0;
            this.BsStandartToolStrip.BsSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsSaveButtonClicked);
            // 
            // BsPanelFill
            // 
            this.BsPanelFill.Controls.Add(this.BsAdgv);
            this.BsPanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BsPanelFill.Location = new System.Drawing.Point(0, 213);
            this.BsPanelFill.Margin = new System.Windows.Forms.Padding(4);
            this.BsPanelFill.Name = "BsPanelFill";
            this.BsPanelFill.Size = new System.Drawing.Size(1179, 328);
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
            this.BsAdgv.Margin = new System.Windows.Forms.Padding(4);
            this.BsAdgv.MultiSelect = false;
            this.BsAdgv.Name = "BsAdgv";
            this.BsAdgv.ReadOnly = true;
            this.BsAdgv.RowHeadersVisible = false;
            this.BsAdgv.RowHeadersWidth = 51;
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BsAdgv.Size = new System.Drawing.Size(1179, 328);
            this.BsAdgv.TabIndex = 1;
            // 
            // BsFormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.BsPanelFill);
            this.Controls.Add(this.BsPanelTop);
            this.Controls.Add(this.BsStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        protected BsAdvDataGridView BsAdgv;
        protected System.Windows.Forms.BindingSource BsBindingSource;
        protected System.Windows.Forms.Panel BsPanelTop;
        protected System.Windows.Forms.Panel BsPanelFill;
        protected BsStandartToolStrip BsStandartToolStrip;
    }
}