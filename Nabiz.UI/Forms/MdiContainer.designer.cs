using BigSoft.Framework.Controls;

namespace Nabiz.UI
{
    partial class MdiContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okTabBrowser = new BigSoft.Framework.Controls.BsTabBrowser();
            this.menuQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.questionToolStripMenuItem,
            this.menuQuestion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(42, 20);
            this.menuUser.Text = "User";
            this.menuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // okTabBrowser
            // 
            this.okTabBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.okTabBrowser.Location = new System.Drawing.Point(0, 24);
            this.okTabBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okTabBrowser.Name = "okTabBrowser";
            this.okTabBrowser.Size = new System.Drawing.Size(995, 22);
            this.okTabBrowser.TabIndex = 21;
            // 
            // menuQuestion
            // 
            this.menuQuestion.Name = "menuQuestion";
            this.menuQuestion.Size = new System.Drawing.Size(67, 20);
            this.menuQuestion.Text = "Question";
            this.menuQuestion.Click += new System.EventHandler(this.MenuQuestion_Click);
            // 
            // MdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(995, 603);
            this.Controls.Add(this.okTabBrowser);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MdiContainer";
            this.Text = "Medya Takip v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BsTabBrowser okTabBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuestion;
    }
}