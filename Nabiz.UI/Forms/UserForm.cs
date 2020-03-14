using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using Nabiz.Business;
using Nabiz.Data.Model;
using System;
using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class UserForm : BsForm
    {
        #region Public Constructors

        public UserForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void Button1_Click(object sender, EventArgs e)
        {
            OUserSave save = new OUserSave(Guid.NewGuid().ToString());
            var result = save.Execute();
            BsMessageBox.Show(result);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            OUserGet get = new OUserGet();
            var result = get.Execute();
            dgvUser.BsDataSourceList(result.Value);

            //advancedDataGridView1.DataSource = result.Value;
            bsAdvDataGridView1.DataSource = result.Value;
            //advancedDataGridView1.DataSource = result.Value;
            FillScreen(bsAdvDataGridView1.DataRowToObject<User>(bsAdvDataGridView1.CurrentGridRow));
        }

        #endregion Private Methods

        private void bsAdvDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            FillScreen(bsAdvDataGridView1.DataRowToObject<User>(bsAdvDataGridView1.CurrentGridRow));
        }
    }
}