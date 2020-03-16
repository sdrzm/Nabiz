using BigSoft.Framework.Util;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public sealed partial class BsStandartToolStrip : UserControl
    {
        #region Public Constructors

        public BsStandartToolStrip()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler BsDeleteButtonClicked;

        public event EventHandler BsGetButtonClicked;

        public event EventHandler BsRefreshButtonClicked;

        public event EventHandler BsSaveButtonClicked;

        public event EventHandler BsSearchButtonClicked;

        public event EventHandler BsUpdateButtonClicked;

        #endregion Public Events

        #region Private Methods

        private void ClearControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox box)
                {
                    box.Clear();
                }
                else if (control is CheckBox check)
                {
                    check.Checked = false;
                }
                else if (control is ComboBox cbox)
                {
                    cbox.SelectedIndex = -1;
                    cbox.Text = "";
                }
                else if (control is ListBox lbox)
                {
                    lbox.Items.Clear();
                }
                else if (control is ListView lview)
                {
                    lview.Items.Clear();
                }
                else if (control is GroupBox gbox)
                {
                    ClearControls(gbox);
                }
                else if (control is Panel panel)
                {
                    ClearControls(panel);
                }
            }

            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
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

        private void TsbClear_Click_1(object sender, EventArgs e)
        {
            Control form = ((((ToolStripButton)sender).Owner).Parent).Parent;
            ClearControls(form);
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Form parentForm = (Form)GetForm();
            parentForm?.Close();
        }

        private void TsbGet_Click(object sender, EventArgs e)
        {
            if (tsbGet != null)
                BsGetButtonClicked?.Invoke(sender, e);
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            BsRefreshButtonClicked?.Invoke(sender, e);
        }

        private void TsbSearch_Click(object sender, EventArgs e)
        {
            BsSearchButtonClicked?.Invoke(sender, e);
        }

        private void TsbUpdate_Click_1(object sender, EventArgs e)
        {
            BsUpdateButtonClicked?.Invoke(sender, e);
        }

        #endregion Private Methods

        #region Public Methods

        public void DisableSave()
        {
            tsbSave.Enabled = false;
        }

        public void DisableUpdateDelete()
        {
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
        }

        public void EnableSave()
        {
            tsbSave.Enabled = true;
        }

        public void EnableUpdateDelete()
        {
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
        }

        public void TsbDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = BsMessageBox.Ask("Silmek istediğinize emin misiniz?");
            if (result == DialogResult.No) return;
            BsDeleteButtonClicked?.Invoke(sender, e);
        }

        public void TsbSave_Click_1(object sender, EventArgs e)
        {
            BsSaveButtonClicked?.Invoke(sender, e);
        }

        #endregion Public Methods

        #region Button Visible Status

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkClearButtonVisible
        {
            get => tsbClear.Visible;
            set => tsbClear.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkDeleteButtonVisible
        {
            get => tsbDelete.Visible;
            set => tsbDelete.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkGetButtonVisible
        {
            get => tsbGet.Visible;
            set => tsbGet.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkRefreshButtonVisible
        {
            get => tsbRefresh.Visible;
            set => tsbRefresh.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkSaveButtonVisible
        {
            get => tsbSave.Visible;
            set => tsbSave.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool OkSearchButtonVisible
        {
            get => tsbSearch.Visible;
            set => tsbSearch.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool OkUpdateButtonVisible
        {
            get => tsbUpdate.Visible;
            set => tsbUpdate.Visible = value;
        }

        #endregion Button Visible Status

        #region Button Enabled Status

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkClearButtonEnabled
        {
            get => tsbClear.Enabled;
            set => tsbClear.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkDeleteButtonEnabled
        {
            get => tsbDelete.Enabled;
            set => tsbDelete.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkGetButtonEnabled
        {
            get => tsbGet.Enabled;
            set => tsbGet.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSaveButtonEnabled
        {
            get => tsbSave.Enabled;
            set => tsbSave.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkSearchButtonEnabled
        {
            get => tsbSearch.Enabled;
            set => tsbSearch.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool OkUpdateButtonEnabled
        {
            get => tsbUpdate.Enabled;
            set => tsbUpdate.Enabled = value;
        }

        #endregion Button Enabled Status
    }
}