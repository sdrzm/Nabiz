using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using Nabiz.Business;
using Nabiz.Data.Model;
using System;

namespace Nabiz.UI.Forms
{
    public partial class UserForm : BsFormGrid
    {
        public UserForm() => InitializeComponent();

        #region Events

        private void BsStandartToolStrip_BsGetButtonClicked(object sender, EventArgs e)
        {
            GetFromReady();
        }

        private void BsStandartToolStrip_BsSaveButtonClicked(object sender, EventArgs e)
        {
            if (OpResult.ResultType != ResultType.Successful)
                return;

            User obj = SetFromScreen<User>();
            OUserSave save = new OUserSave(obj);
            var result = save.Execute();
            BsMessageBox.Show(result);
            ClearControls();
            GetFromReady();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            GetFromReady();
        }

        private void BsAdgv_SelectionChanged(object sender, EventArgs e)
        {
            FillScreen(DataRowToObject<User>(BsAdgv.SelectedRows));
        }

        private void BtnMacAddress_Click(object sender, EventArgs e)
        {
            txtMacAddress.Text = Guid.NewGuid().ToString();
        }

        #endregion Events

        private void GetFromReady()
        {
            OUserGet get = new OUserGet(txtMacAddress.Text);
            var result = get.Execute();
            BindDataAsList(result.Value);
        }
    }
}