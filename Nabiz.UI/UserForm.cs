using BigSoft.Framework.Util;
using Nabiz.Business;
using System;
using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OUserSave save = new OUserSave(Guid.NewGuid().ToString());
            var bsOperationResult = save.Execute();
            BsMessageBox.Show(bsOperationResult);
        }
    }
}