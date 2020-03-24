using BigSoft.Framework.Controls;
using Nabiz.UI.Forms;
using System;
using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class MdiContainer : Form
    {
        public UserForm UserForm;
        public QuestionForm QuestionForm;

        public MdiContainer()
        {
            InitializeComponent();
            okTabBrowser.SetMdiForm(this);
        }

        private void MenuUser_Click(object sender, System.EventArgs e)
        {
            ShowForm(ref UserForm);
        }

        private void MenuQuestion_Click(object sender, System.EventArgs e)
        {
            ShowForm(ref QuestionForm);
        }

        private void ShowForm<T>(ref T form) where T : BsForm
        {
            if (form?.IsDisposed != false)
            {
                form = (T)Activator.CreateInstance(typeof(T));
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }
    }
}