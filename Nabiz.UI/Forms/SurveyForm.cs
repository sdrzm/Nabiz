using BigSoft.Framework.Controls;
using BigSoft.Framework.Util;
using Nabiz.Business;
using Nabiz.Data.Model;
using System;

namespace Nabiz.UI.Forms
{
    public partial class SurveyForm : BsFormGrid
    {
        public SurveyForm() => InitializeComponent();

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
            GetFromReady();
        }

        private void BsStandartToolStrip_BsUpdateButtonClicked(object sender, EventArgs e)
        {
            if (OpResult.ResultType != ResultType.Successful)
                return;

            User obj = SetFromScreen<User>();
            OUserUpdate update = new OUserUpdate(obj);
            var result = update.Execute();
            BsMessageBox.Show(result);
            GetFromReady();
        }

        private void BsStandartToolStrip_BsDeleteButtonClicked(object sender, EventArgs e)
        {
            User obj = SetFromScreen<User>();
            OUserDelete delete = new OUserDelete(obj);
            var result = delete.Execute();
            BsMessageBox.Show(result);
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
            ClearControls();
            OUserGet get = new OUserGet(txtMacAddress.Text);
            var result = get.Execute();
            if (result.ResultType == ResultType.Successful)
                BindDataAsList(result.Value);
        }
    }
}