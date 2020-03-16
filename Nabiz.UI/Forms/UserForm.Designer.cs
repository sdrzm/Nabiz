namespace Nabiz.UI.Forms
{
    partial class UserForm
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
            this.bsTextBox1 = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BsStandartToolStrip
            // 
            this.BsStandartToolStrip.OkClearButtonVisible = true;
            this.BsStandartToolStrip.OkDeleteButtonVisible = true;
            this.BsStandartToolStrip.OkGetButtonVisible = true;
            this.BsStandartToolStrip.OkSaveButtonVisible = true;
            this.BsStandartToolStrip.OkUpdateButtonVisible = true;
            // 
            // BsAdgv
            // 
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionChanged += new System.EventHandler(this.BsAdgv_SelectionChanged);
            // 
            // BsPanelTop
            // 
            this.BsPanelTop.Controls.Add(this.groupBox1);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox1, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.BsStandartToolStrip, 0);
            // 
            // bsTextBox1
            // 
            this.bsTextBox1.BsDataClassName = "User";
            this.bsTextBox1.BsDataFieldName = "MacAddress";
            this.bsTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bsTextBox1.Location = new System.Drawing.Point(3, 16);
            this.bsTextBox1.Name = "bsTextBox1";
            this.bsTextBox1.Size = new System.Drawing.Size(196, 20);
            this.bsTextBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bsTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mac Address";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).EndInit();
            this.BsPanelTop.ResumeLayout(false);
            this.BsPanelTop.PerformLayout();
            this.BsPanelFill.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BigSoft.Framework.Controls.BsTextBox bsTextBox1;
    }
}