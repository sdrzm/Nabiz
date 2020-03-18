using BigSoft.Framework.Controls;
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
            GetFromReady();
        }

        private void BsStandartToolStrip_BsSaveButtonClicked(object sender, EventArgs e)
        {
            User obj = new User();
            SetFromScreen(obj);
        }

        private void BsAdgv_SelectionChanged(object sender, EventArgs e)
        {
            FillScreen(DataRowToObject<User>(BsAdgv.SelectedRows));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OUserSave save = new OUserSave(Guid.NewGuid().ToString());
            var result = save.Execute();
            BsMessageBox.Show(result);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            GetFromReady();
        }

        #endregion Events

        #region Private Methods

        private void GetFromReady()
        {
            OUserGet get = new OUserGet(txtMacAddress.Text);
            var result = get.Execute();
            BindDataAsList(result.Value);
        }

        #endregion Private Methods
    }
}