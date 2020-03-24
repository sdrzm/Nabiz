namespace Nabiz.UI.Forms
{
    partial class QuestionForm
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
            this.txtQuestionText = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.cmbChoiceType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbChoiceGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BsAdgv
            // 
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionChanged += new System.EventHandler(this.BsAdgv_SelectionChanged);
            // 
            // BsPanelTop
            // 
            this.BsPanelTop.Controls.Add(this.groupBox3);
            this.BsPanelTop.Controls.Add(this.groupBox2);
            this.BsPanelTop.Controls.Add(this.groupBox1);
            this.BsPanelTop.Controls.SetChildIndex(this.BsGuid, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.BsStandartToolStrip, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox1, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox2, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox3, 0);
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
            this.groupBox1.Controls.Add(this.txtQuestionText);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.BsDataClassName = "User";
            this.txtQuestionText.BsDataFieldName = "MacAddress";
            this.txtQuestionText.BsInt = 0;
            this.txtQuestionText.BsLong = ((long)(0));
            this.txtQuestionText.BsShort = ((short)(0));
            this.txtQuestionText.BsValidatable = true;
            this.txtQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuestionText.Location = new System.Drawing.Point(3, 16);
            this.txtQuestionText.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(390, 65);
            this.txtQuestionText.TabIndex = 5;
            // 
            // cmbChoiceType
            // 
            this.cmbChoiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChoiceType.FormattingEnabled = true;
            this.cmbChoiceType.Location = new System.Drawing.Point(3, 16);
            this.cmbChoiceType.Name = "cmbChoiceType";
            this.cmbChoiceType.Size = new System.Drawing.Size(124, 21);
            this.cmbChoiceType.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbChoiceType);
            this.groupBox2.Location = new System.Drawing.Point(414, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choice Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbChoiceGroup);
            this.groupBox3.Location = new System.Drawing.Point(550, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 49);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ChoiceGroup";
            // 
            // cmbChoiceGroup
            // 
            this.cmbChoiceGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChoiceGroup.FormattingEnabled = true;
            this.cmbChoiceGroup.Location = new System.Drawing.Point(3, 16);
            this.cmbChoiceGroup.Name = "cmbChoiceGroup";
            this.cmbChoiceGroup.Size = new System.Drawing.Size(115, 21);
            this.cmbChoiceGroup.TabIndex = 0;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).EndInit();
            this.BsPanelTop.ResumeLayout(false);
            this.BsPanelTop.PerformLayout();
            this.BsPanelFill.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BigSoft.Framework.Controls.BsTextBox txtQuestionText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbChoiceGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbChoiceType;
    }
}