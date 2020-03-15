using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public class BsForm : Form
    {
        #region Public Constructors

        public BsForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Fields

        protected readonly Dictionary<string, object> _mappableControls = new Dictionary<string, object>();

        #endregion Private Fields

        #region Events

        private void BsForm_Load(object sender, EventArgs e)
        {
            UpdateUI(this);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CloseTab();
            base.OnClosing(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            BsStandartToolStrip toolStrip = Controls.OfType<BsStandartToolStrip>().FirstOrDefault();
            List<TextBox> textBoxes = Controls.OfType<TextBox>().ToList();
            switch (keyData)
            {
                case (Keys.Control | Keys.S):
                    if (toolStrip.OkSaveButtonEnabled)
                        toolStrip.TsbSave_Click_1(null, null);
                    return true;

                case Keys.Delete:
                    if (textBoxes.Any(a => a.Focused))
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                    else if (toolStrip.OkDeleteButtonEnabled)
                    {
                        toolStrip.TsbDelete_Click_1(null, null);
                        return true;
                    }
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion Events

        #region Private Methods

        private void CloseTab()
        {
            Form form = this;
            if (Parent == null) return;
            foreach (BsTabBrowser c in Parent.Parent.Controls.OfType<BsTabBrowser>())
            {
                c.DisposeTabPage(form);
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            //
            // BsForm
            //
            ClientSize = new System.Drawing.Size(884, 461);
            Name = "BsForm";
            Load += BsForm_Load;
            ResumeLayout(false);
        }

        private void UpdateUI(Control ctrl)
        {
            foreach (Control _ctrl in ctrl.Controls)
            {
                if (_ctrl is IBsMappable i && !string.IsNullOrEmpty(i.BsDataClassName) && !string.IsNullOrEmpty(i.BsDataFieldName))
                {
                    string key = i.BsDataClassName + "~" + i.BsDataFieldName;
                    if (!_mappableControls.ContainsKey(key))
                        _mappableControls.Add(key, _ctrl);
                }

                if (_ctrl.HasChildren)
                {
                    UpdateUI(_ctrl);
                }
            }
        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        /// Clear all controls in form
        /// </summary>
        public static void Clear(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox box)
                {
                    box.Clear();
                }
                if (control is MaskedTextBox mbox)
                {
                    mbox.Clear();
                }
                if (control is ListView view)
                {
                    view.Items.Clear();
                }
                if (control is GroupBox gbox)
                {
                    foreach (Control control1 in gbox.Controls)
                    {
                        if (control1 is TextBox box1)
                        {
                            box1.Clear();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sets screens control values using the object. Objects fields matches with controls BsDataClassName and
        /// BsDataFieldName
        /// </summary>
        /// <param name="obj">Source object that will fill screen</param>
        public void FillScreen(object obj)
        {
            if (obj == null || obj is Array)
                return;

            string className = obj.GetType().Name;

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.IsSealed)
                {
                    if (_mappableControls.ContainsKey(className + '~' + property.Name))
                    {
                        object control = _mappableControls[className + '~' + property.Name];
                        object value = property.GetValue(obj);
                        ((IBsMappable)control).SetValue(value);
                    }
                }
                else
                {
                    FillScreen(property.GetValue(obj, null));
                }
            }

            foreach (FieldInfo field in obj.GetType().GetFields())
            {
                if (_mappableControls.ContainsKey(className + '~' + field.Name))
                {
                    object control = _mappableControls[className + '~' + field.Name];
                    object value = field.GetValue(obj);
                    ((IBsMappable)control).SetValue(value);
                }
            }
        }

        /// <summary>
        /// Set an objects attributes. Values are taken from screen controls which has BsDataClassName and BsDataFieldName
        /// properties.
        /// </summary>
        /// <param name="obj">Object that attributes will be set</param>
        /// <returns>Input object</returns>
        public object SetFromScreen(object obj)
        {
            if (obj == null)
                return obj;

            string className = obj.GetType().Name;

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (_mappableControls.ContainsKey(className + '~' + property.Name))
                {
                    object control = _mappableControls[className + '~' + property.Name];
                    object controlValue = ((IBsMappable)control).GetValue(property.PropertyType);
                    property.SetValue(obj, controlValue);
                }
            }

            foreach (FieldInfo field in obj.GetType().GetFields())
            {
                if (_mappableControls.ContainsKey(className + '~' + field.Name))
                {
                    object control = _mappableControls[className + '~' + field.Name];
                    object controlValue = ((IBsMappable)control).GetValue(field.FieldType);
                    field.SetValue(obj, controlValue);
                }
            }
            return obj;
        }

        #endregion Public Methods
    }
}