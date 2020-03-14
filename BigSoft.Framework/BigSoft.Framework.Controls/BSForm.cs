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

        private readonly Dictionary<string, List<object>> _mappableControls = new Dictionary<string, List<object>>();

        #endregion Private Fields

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
            this.SuspendLayout();
            //
            // BsForm
            //
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BsForm";
            this.Load += new System.EventHandler(this.BsForm_Load);
            this.ResumeLayout(false);
        }

        private void UpdateUI(Control ctrl)
        {
            foreach (Control _ctrl in ctrl.Controls)
            {
                if (_ctrl is IBsMappable i && !string.IsNullOrEmpty(i.BsDataClassName) && !string.IsNullOrEmpty(i.BsDataFieldName))
                {
                    string Key = i.BsDataClassName + "~" + i.BsDataFieldName;
                    if (_mappableControls.ContainsKey(Key))
                    {
                        _mappableControls[Key].Add(_ctrl);
                    }
                    else
                    {
                        List<object> controls = new List<object> { _ctrl };
                        _mappableControls.Add(Key, controls);
                    }
                }
            }
        }

        #endregion Private Methods

        #region Public Methods

        private static void SetControlsValue(List<object> control, object value)
        {
            for (int i = 0; i < control.Count; i++)
            {
                IBsMappable m = (IBsMappable)control[i];
                m.SetValue(value);
            }
        }

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
        /// Sets screens controls values using the object. Objects fields matches with controls swPomDataClass and
        /// swPOMDAtaFieldName
        /// </summary>
        /// <param name="obj">Source object that will fill screen</param>
        /// <param name="control">Control collection that controls will be filled</param>
        public void FillScreen(object obj)
        {
            if (obj == null || obj is Array)
                return;

            string ClassName = obj.GetType().Name;

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.IsSealed)
                {
                    if (_mappableControls.ContainsKey(ClassName + '~' + property.Name))
                    {
                        List<object> controls = _mappableControls[ClassName + '~' + property.Name];
                        object value = property.GetValue(obj, null);
                        SetControlsValue(controls, value);
                    }
                }
                else
                {
                    FillScreen(property.GetValue(obj, null));
                }
            }

            foreach (FieldInfo Field in obj.GetType().GetFields())
            {
                if (_mappableControls.ContainsKey(ClassName + '~' + Field.Name))
                {
                    List<object> controls = _mappableControls[ClassName + '~' + Field.Name];
                    object value = Field.GetValue(obj);
                    SetControlsValue(controls, value);
                }
            }
        }

        /// <summary>
        /// Set an objects attributes. Values are taken from screen controls which has BsDataClassName and BsDataFieldName
        /// properties.
        /// </summary>
        /// <param name="obj">Object that attributes will be set</param>
        /// <param name="control">Container control that has mapped controls to obj's fields</param>
        /// <returns>Input object</returns>
        public object SetFromScreen(object obj)
        {
            if (obj == null)
                return obj;

            string ClassName = obj.GetType().Name;

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (_mappableControls.ContainsKey(ClassName + '~' + property.Name))
                {
                    List<object> controls = _mappableControls[ClassName + '~' + property.Name];
                    for (int i = 0; i < controls.Count; i++)
                    {
                        object controlValue = ((IBsMappable)Controls[i]).GetValue(property.PropertyType);
                        property.SetValue(obj, controlValue, null);
                    }
                }
            }

            foreach (FieldInfo Field in obj.GetType().GetFields())
            {
                if (_mappableControls.ContainsKey(ClassName + '~' + Field.Name))
                {
                    List<object> controls = _mappableControls[ClassName + '~' + Field.Name];
                    for (int i = 0; i < controls.Count; i++)
                    {
                        object ControlValue = ((IBsMappable)Controls[i]).GetValue(Field.FieldType);
                        Field.SetValue(obj, ControlValue);
                    }
                }
            }
            return obj;
        }

        #endregion Public Methods

        #region Protected Methods

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

        #endregion Protected Methods

        private void BsForm_Load(object sender, System.EventArgs e)
        {
            UpdateUI(this);
        }
    }
}