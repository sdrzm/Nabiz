namespace Nabiz.UI.Forms
{
    partial class SurveyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMacAddress = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.btnMacAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BsAdgv
            // 
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionChanged += new System.EventHandler(this.BsAdgv_SelectionChanged);
            // 
            // BsPanelTop
            // 
            this.BsPanelTop.Controls.Add(this.btnMacAddress);
            this.BsPanelTop.Controls.Add(this.groupBox1);
            this.BsPanelTop.Controls.SetChildIndex(this.BsGuid, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox1, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.BsStandartToolStrip, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.btnMacAddress, 0);
            // 
            // BsStandartToolStrip
            // 
            this.BsStandartToolStrip.BsClearButtonVisible = true;
            this.BsStandartToolStrip.BsDeleteButtonEnabled = false;
            this.BsStandartToolStrip.BsDeleteButtonVisible = true;
            this.BsStandartToolStrip.BsGetButtonVisible = true;
            this.BsStandartToolStrip.BsSaveButtonVisible = true;
            this.BsStandartToolStrip.BsUpdateButtonVisible = true;
            this.BsStandartToolStrip.BsDeleteButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsDeleteButtonClicked);
            this.BsStandartToolStrip.BsGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsGetButtonClicked);
            this.BsStandartToolStrip.BsSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsSaveButtonClicked);
            this.BsStandartToolStrip.BsUpdateButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsUpdateButtonClicked);
            // 
            // BsGuid
            // 
            this.BsGuid.BsDataClassName = "User";
            this.BsGuid.Location = new System.Drawing.Point(822, 147);
            this.BsGuid.Size = new System.Drawing.Size(50, 20);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMacAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BsDataClassName = "User";
            this.txtMacAddress.BsDataFieldName = "MacAddress";
            this.txtMacAddress.BsInt = 0;
            this.txtMacAddress.BsLong = ((long)(0));
            this.txtMacAddress.BsShort = ((short)(0));
            this.txtMacAddress.BsValidatable = true;
            this.txtMacAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMacAddress.Location = new System.Drawing.Point(3, 16);
            this.txtMacAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtMacAddress.Multiline = true;
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(482, 69);
            this.txtMacAddress.TabIndex = 5;
            // 
            // btnMacAddress
            // 
            this.btnMacAddress.Location = new System.Drawing.Point(797, 52);
            this.btnMacAddress.Name = "btnMacAddress";
            this.btnMacAddress.Size = new System.Drawing.Size(75, 23);
            this.btnMacAddress.TabIndex = 5;
            this.btnMacAddress.Text = "Generate";
            this.btnMacAddress.UseVisualStyleBackColor = true;
            this.btnMacAddress.Click += new System.EventHandler(this.BtnMacAddress_Click);
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SurveyForm";
            this.Text = "SurveyForm";
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
        private BigSoft.Framework.Controls.BsTextBox txtMacAddress;
        private System.Windows.Forms.Button btnMacAddress;
    }
}