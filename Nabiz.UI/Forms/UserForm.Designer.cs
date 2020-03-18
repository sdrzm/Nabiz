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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMacAddress = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.bsAdvDataGridView1 = new BigSoft.Framework.Controls.BsAdvDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BsAdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsBindingSource)).BeginInit();
            this.BsPanelTop.SuspendLayout();
            this.BsPanelFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BsAdgv
            // 
            this.BsAdgv.RowTemplate.Height = 20;
            this.BsAdgv.SelectionChanged += new System.EventHandler(this.BsAdgv_SelectionChanged);
            // 
            // BsPanelTop
            // 
            this.BsPanelTop.Controls.Add(this.bsAdvDataGridView1);
            this.BsPanelTop.Controls.Add(this.groupBox1);
            this.BsPanelTop.Controls.SetChildIndex(this.groupBox1, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.BsStandartToolStrip, 0);
            this.BsPanelTop.Controls.SetChildIndex(this.bsAdvDataGridView1, 0);
            // 
            // BsStandartToolStrip
            // 
            this.BsStandartToolStrip.BsClearButtonVisible = true;
            this.BsStandartToolStrip.BsDeleteButtonEnabled = false;
            this.BsStandartToolStrip.BsDeleteButtonVisible = true;
            this.BsStandartToolStrip.BsGetButtonVisible = true;
            this.BsStandartToolStrip.BsSaveButtonVisible = true;
            this.BsStandartToolStrip.BsUpdateButtonVisible = true;
            this.BsStandartToolStrip.BsGetButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsGetButtonClicked);
            this.BsStandartToolStrip.BsSaveButtonClicked += new System.EventHandler(this.BsStandartToolStrip_BsSaveButtonClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMacAddress);
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(269, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mac Address";
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BsDataClassName = "User";
            this.txtMacAddress.BsDataFieldName = "MacAddress";
            this.txtMacAddress.BsValidatable = true;
            this.txtMacAddress.Location = new System.Drawing.Point(7, 22);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(255, 22);
            this.txtMacAddress.TabIndex = 5;
            // 
            // bsAdvDataGridView1
            // 
            this.bsAdvDataGridView1.AllowUserToAddRows = false;
            this.bsAdvDataGridView1.AllowUserToDeleteRows = false;
            this.bsAdvDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bsAdvDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bsAdvDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bsAdvDataGridView1.ColumnHeadersHeight = 29;
            this.bsAdvDataGridView1.FilterAndSortEnabled = true;
            this.bsAdvDataGridView1.Location = new System.Drawing.Point(583, 12);
            this.bsAdvDataGridView1.MultiSelect = false;
            this.bsAdvDataGridView1.Name = "bsAdvDataGridView1";
            this.bsAdvDataGridView1.ReadOnly = true;
            this.bsAdvDataGridView1.RowHeadersVisible = false;
            this.bsAdvDataGridView1.RowHeadersWidth = 51;
            this.bsAdvDataGridView1.RowTemplate.Height = 20;
            this.bsAdvDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bsAdvDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.bsAdvDataGridView1.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Margin = new System.Windows.Forms.Padding(5);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BigSoft.Framework.Controls.BsTextBox txtMacAddress;
        private BigSoft.Framework.Controls.BsAdvDataGridView bsAdvDataGridView1;
    }
}