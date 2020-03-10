using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsTabBrowser : UserControl
    {
        private Form _mdiForm;
        private readonly Dictionary<Form, TabPage> _formsAndPages = new Dictionary<Form, TabPage>();

        public BsTabBrowser()
        {
            InitializeComponent();
        }

        public void SetMdiForm(Form mdiForm)
        {
            _mdiForm = mdiForm;
            _mdiForm.MdiChildActivate += MdiForm_MdiChildActivate;
        }

        private void MdiForm_MdiChildActivate(object sender, EventArgs e)
        {
            Form form = ((Form)sender).ActiveMdiChild;
            if (form == null)
                return;

            if (_formsAndPages.ContainsKey(form))
                ActivatePage(form);
            else
                AddPage(form);
        }

        private void ActivatePage(Form childForm)
        {
            foreach (KeyValuePair<Form, TabPage> formAndPage in _formsAndPages)
            {
                Form form = formAndPage.Key;
                TabPage tabPage = formAndPage.Value;

                if (form != childForm) continue;

                form.Select();
                tabControl.SelectedTab = tabPage;
                break;
            }
        }

        private void AddPage(Form form)
        {
            TabPage tab = new TabPage
            {
                Text = form.Text,
                Parent = tabControl
            };
            _formsAndPages.Add(form, tab);
            tabControl.SelectedTab = tab;
            tabControl.Visible = true;
        }

        public void DisposeTabPage(Form form)
        {
            _formsAndPages[form].Dispose();
            _formsAndPages.Remove(form);

            if (_formsAndPages.Count == 0)
                tabControl.Visible = false;
        }

        private void TabControl_Click(object sender, EventArgs e)
        {
            Form form = (from u in _formsAndPages
                         where u.Value == tabControl.SelectedTab
                         select u.Key).FirstOrDefault();

            ActivatePage(form);
        }
    }
}