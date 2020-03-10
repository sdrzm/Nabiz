using BigSoft.Framework.Util;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public sealed partial class BsStandartToolStrip : UserControl
    {
        public event EventHandler OkGetButtonClicked;

        public event EventHandler OkUpdateButtonClicked;

        public event EventHandler OkDeleteButtonClicked;

        public event EventHandler OkSaveButtonClicked;

        public event EventHandler OkSearchButtonClicked;

        public event EventHandler OkRefreshButtonClicked;

        public BsStandartToolStrip()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private Control GetForm()
        {
            Control parent = Parent;
            while (parent != null)
            {
                if (parent is Form)
                    break;
                parent = parent.Parent;
            }
            try
            {
                if (parent != null)
                    return parent;
            }
            catch (Exception ex)
            {
                BsMessageBox.ShowError(ex.ToString());
            }
            return null;
        }

        private void TsbGet_Click(object sender, EventArgs e)
        {
            if (tsbGet != null)
                OkGetButtonClicked?.Invoke(sender, e);
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Form parentForm = (Form)GetForm();
            parentForm?.Close();
        }

        private void TsbClear_Click_1(object sender, EventArgs e)
        {
            Control form = ((((ToolStripButton)sender).Owner).Parent).Parent;
            ClearControls(form);
        }

        private void ClearControls(Control form)
        {
            foreach (Control c in form.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).Clear();
                }
                else if (c.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    ((ComboBox)c).Text = "";
                }
                else if (c.GetType() == typeof(ListBox))
                {
                    ((ListBox)c).Items.Clear();
                }
                else if (c.GetType() == typeof(ListView))
                {
                    ((ListView)c).Items.Clear();
                }
                else if (c.GetType() == typeof(BsListView))
                {
                    if (!(c is BsListView okListView)) continue;
                    for (int i = 0; i < okListView.SelectedIndices.Count; i++)
                    {
                        okListView.Items[okListView.SelectedIndices[i]].Selected = false;
                    }
                }
                else if (c.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c.GetType() == typeof(GroupBox))
                {
                    ClearControls(c);
                }
                else if (c.GetType() == typeof(Panel))
                {
                    ClearControls(c);
                }
            }

            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
        }

        public void TsbSave_Click_1(object sender, EventArgs e)
        {
            OkSaveButtonClicked?.Invoke(sender, e);
        }

        private void TsbUpdate_Click_1(object sender, EventArgs e)
        {
            OkUpdateButtonClicked?.Invoke(sender, e);
        }

        public void TsbDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = BsMessageBox.Ask("Silmek istediğinize emin misiniz?");
            if (result == DialogResult.No) return;
            OkDeleteButtonClicked?.Invoke(sender, e);
        }

        private void TsbSearch_Click(object sender, EventArgs e)
        {
            OkSearchButtonClicked?.Invoke(sender, e);
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            OkRefreshButtonClicked?.Invoke(sender, e);
        }

        #region Button Visible Status

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkGetButtonVisible
        {
            get { return tsbGet.Visible; }
            set { tsbGet.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkSearchButtonVisible
        {
            get { return tsbSearch.Visible; }
            set { tsbSearch.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkSaveButtonVisible
        {
            get { return tsbSave.Visible; }
            set { tsbSave.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkUpdateButtonVisible
        {
            get { return tsbUpdate.Visible; }
            set { tsbUpdate.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkDeleteButtonVisible
        {
            get { return tsbDelete.Visible; }
            set { tsbDelete.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkClearButtonVisible
        {
            get { return tsbClear.Visible; }
            set { tsbClear.Visible = value; }
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkRefreshButtonVisible
        {
            get { return tsbRefresh.Visible; }
            set { tsbRefresh.Visible = value; }
        }

        #endregion Button Visible Status

        #region Button Enabled Status

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkGetButtonEnabled
        {
            get { return tsbGet.Enabled; }
            set { tsbGet.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSearchButtonEnabled
        {
            get { return tsbSearch.Enabled; }
            set { tsbSearch.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSaveButtonEnabled
        {
            get { return tsbSave.Enabled; }
            set { tsbSave.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkUpdateButtonEnabled
        {
            get { return tsbUpdate.Enabled; }
            set { tsbUpdate.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkDeleteButtonEnabled
        {
            get { return tsbDelete.Enabled; }
            set { tsbDelete.Enabled = value; }
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkClearButtonEnabled
        {
            get { return tsbClear.Enabled; }
            set { tsbClear.Enabled = value; }
        }

        #endregion Button Enabled Status

        public void EnableUpdateDelete()
        {
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
        }

        public void DisableUpdateDelete()
        {
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
        }

        public void DisableSave()
        {
            tsbSave.Enabled = false;
        }

        public void EnableSave()
        {
            tsbSave.Enabled = true;
        }
    }
}