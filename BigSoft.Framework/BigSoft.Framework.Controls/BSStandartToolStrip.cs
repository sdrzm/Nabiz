using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public sealed partial class BsStandartToolStrip : UserControl
    {
        public BsStandartToolStrip()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        public event EventHandler BsDeleteButtonClicked;

        public event EventHandler BsGetButtonClicked;

        public event EventHandler BsRefreshButtonClicked;

        public event EventHandler BsSaveButtonClicked;

        public event EventHandler BsSearchButtonClicked;

        public event EventHandler BsUpdateButtonClicked;

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

        #region Events

        private void TsbClear_Click(object sender, EventArgs e)
        {
            BsForm bsForm = (BsForm)Parent.Parent;
            bsForm.ClearControls();
            DisableUpdateDelete();
        }

        private void TsbExit_Click(object sender, EventArgs e)
        {
            Form parentForm = (Form)GetForm();
            parentForm?.Close();
        }

        private void TsbGet_Click(object sender, EventArgs e)
        {
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

        private void TsbUpdate_Click(object sender, EventArgs e)
        {
            BsUpdateButtonClicked?.Invoke(sender, e);
        }

        public void TsbSave_Click(object sender, EventArgs e)
        {
            BsSaveButtonClicked?.Invoke(sender, e);
        }

        public void TsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = BsMessageBox.Ask("Silmek istediğinize emin misiniz?");
            if (result == DialogResult.No) return;
            BsDeleteButtonClicked?.Invoke(sender, e);
        }

        #endregion Events

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

        #endregion Public Methods

        #region Button Visible Status

        [Category("Visible")]
        [DefaultValue(true)]
        public bool BsClearButtonVisible
        {
            get => tsbClear.Visible;
            set => tsbClear.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool BsDeleteButtonVisible
        {
            get => tsbDelete.Visible;
            set => tsbDelete.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool BsGetButtonVisible
        {
            get => tsbGet.Visible;
            set => tsbGet.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool BsRefreshButtonVisible
        {
            get => tsbRefresh.Visible;
            set => tsbRefresh.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool BsSaveButtonVisible
        {
            get => tsbSave.Visible;
            set => tsbSave.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(false)]
        public bool BsSearchButtonVisible
        {
            get => tsbSearch.Visible;
            set => tsbSearch.Visible = value;
        }

        [Category("Visible")]
        [DefaultValue(true)]
        public bool BsUpdateButtonVisible
        {
            get => tsbUpdate.Visible;
            set => tsbUpdate.Visible = value;
        }

        #endregion Button Visible Status

        #region Button Enabled Status

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool BsClearButtonEnabled
        {
            get => tsbClear.Enabled;
            set => tsbClear.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(false)]
        public bool BsDeleteButtonEnabled
        {
            get => tsbDelete.Enabled;
            set => tsbDelete.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool BsGetButtonEnabled
        {
            get => tsbGet.Enabled;
            set => tsbGet.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(false)]
        public bool BsSaveButtonEnabled
        {
            get => tsbSave.Enabled;
            set => tsbSave.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool BsSearchButtonEnabled
        {
            get => tsbSearch.Enabled;
            set => tsbSearch.Enabled = value;
        }

        [Category("Enabled")]
        [DefaultValue(true)]
        public bool BsUpdateButtonEnabled
        {
            get => tsbUpdate.Enabled;
            set => tsbUpdate.Enabled = value;
        }

        #endregion Button Enabled Status
    }
}