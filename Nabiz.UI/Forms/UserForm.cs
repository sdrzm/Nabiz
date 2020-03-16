using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using Nabiz.Business;
using Nabiz.Data.Model;
using System;

namespace Nabiz.UI.Forms
{
    public partial class UserForm : BsFormGrid
    {
        #region Public Constructors

        public UserForm() => InitializeComponent();

        #endregion Public Constructors

        #region Events

        private void BsStandartToolStrip_BsGetButtonClicked(object sender, EventArgs e)
        {
            OUserGet get = new OUserGet(txtMacAddress.Text);
            var result = get.Execute();
            BindDataAsList(result.Value);
        }

        private void BsAdgv_SelectionChanged(object sender, EventArgs e)
        {
            FillScreen(BsAdgv.DataRowToObject<User>(BsAdgv.CurrentGridRow));
        }

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
            BindDataAsList(result.Value);
        }

        #endregion Events

        #region Private Methods

        private void BsStandartToolStrip_BsSaveButtonClicked(object sender, EventArgs e)

        {
            System.Windows.Forms.MessageBox.Show("Test");
        }

        #endregion Private Methods
    }
}