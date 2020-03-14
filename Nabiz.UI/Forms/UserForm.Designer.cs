namespace Nabiz.UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUser = new BigSoft.Framework.Controls.BsDataGridView(this.components);
            this.bsTextBox1 = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.bsTextBox2 = new BigSoft.Framework.Controls.BsTextBox(this.components);
            this.bsAdvDataGridView1 = new BigSoft.Framework.Controls.BsAdvDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.CurrentGridRow = null;
            this.dgvUser.Location = new System.Drawing.Point(9, 36);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(235, 401);
            this.dgvUser.TabIndex = 2;
            // 
            // bsTextBox1
            // 
            this.bsTextBox1.BsDataClassName = null;
            this.bsTextBox1.BsDataFieldName = null;
            this.bsTextBox1.Location = new System.Drawing.Point(693, 441);
            this.bsTextBox1.Name = "bsTextBox1";
            this.bsTextBox1.Size = new System.Drawing.Size(192, 20);
            this.bsTextBox1.TabIndex = 1;
            // 
            // bsTextBox2
            // 
            this.bsTextBox2.BsDataClassName = "User";
            this.bsTextBox2.BsDataFieldName = "MacAddress";
            this.bsTextBox2.Location = new System.Drawing.Point(719, 393);
            this.bsTextBox2.Name = "bsTextBox2";
            this.bsTextBox2.Size = new System.Drawing.Size(166, 20);
            this.bsTextBox2.TabIndex = 6;
            // 
            // bsAdvDataGridView1
            // 
            this.bsAdvDataGridView1.AllowUserToAddRows = false;
            this.bsAdvDataGridView1.AllowUserToDeleteRows = false;
            this.bsAdvDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bsAdvDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bsAdvDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.bsAdvDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bsAdvDataGridView1.FilterAndSortEnabled = true;
            this.bsAdvDataGridView1.Location = new System.Drawing.Point(249, 36);
            this.bsAdvDataGridView1.MultiSelect = false;
            this.bsAdvDataGridView1.Name = "bsAdvDataGridView1";
            this.bsAdvDataGridView1.ReadOnly = true;
            this.bsAdvDataGridView1.RowHeadersVisible = false;
            this.bsAdvDataGridView1.RowTemplate.Height = 20;
            this.bsAdvDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bsAdvDataGridView1.Size = new System.Drawing.Size(287, 401);
            this.bsAdvDataGridView1.TabIndex = 7;
            this.bsAdvDataGridView1.SelectionChanged += new System.EventHandler(this.bsAdvDataGridView1_SelectionChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 526);
            this.Controls.Add(this.bsAdvDataGridView1);
            this.Controls.Add(this.bsTextBox2);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.bsTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BigSoft.Framework.Controls.BsTextBox bsTextBox1;
        private BigSoft.Framework.Controls.BsDataGridView dgvUser;
        private BigSoft.Framework.Controls.BsTextBox bsTextBox2;
        private BigSoft.Framework.Controls.BsAdvDataGridView bsAdvDataGridView1;
    }
}