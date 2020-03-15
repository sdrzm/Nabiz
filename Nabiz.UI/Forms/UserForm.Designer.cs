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
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
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
            this.BsPanelTop.Controls.Add(this.bsTextBox1);
            this.BsPanelTop.Controls.SetChildIndex(this.BsStandartToolStrip, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.bsTextBox1, 0);
            // 
            // bsTextBox1
            // 
            this.bsTextBox1.BsDataClassName = "User";
            this.bsTextBox1.BsDataFieldName = "MacAddress";
            this.bsTextBox1.Location = new System.Drawing.Point(13, 37);
            this.bsTextBox1.Name = "bsTextBox1";
            this.bsTextBox1.Size = new System.Drawing.Size(456, 20);
            this.bsTextBox1.TabIndex = 3;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BigSoft.Framework.Controls.BsTextBox bsTextBox1;
    }
}