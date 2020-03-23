using BigSoft.Framework.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public class BsForm : Form
    {
        protected readonly Dictionary<string, object> _mappableControls = new Dictionary<string, object>();

        public BsOpResultBase OpResult { get; set; } = new BsOpResultBase();

        public BsForm() => InitializeComponent();

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
            // BsForm
            ClientSize = new Size(884, 461);
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

        protected void CheckValidation(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is IBsValidatable cctrl && cctrl.BsValidatable && cctrl is TextBox box)
                {
                    if (string.IsNullOrEmpty(box.Text))
                    {
                        box.BackColor = Color.MistyRose;
                        OpResult.ResultType = ResultType.UserError;
                        OpResult.Message = "Gerekli alanları doldurun";
                        BsMessageBox.Show(OpResult);
                    }
                    else
                    {
                        box.BackColor = Color.White;
                    }
                }

                if (childControl.HasChildren)
                {
                    CheckValidation(childControl);
                }
            }
        }

        public void FillScreen(object obj)
        {
            if (obj == null || obj is Array)
            {
                ClearControls(false);
                return;
            }

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

        public T SetFromScreen<T>()
        {
            T obj = (T)Activator.CreateInstance(typeof(T));
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

        #region ClearControls

        private void ClearControls(Control form, bool adgv)
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
                    ClearControls(gbox, adgv);
                }
                else if (control is Panel panel)
                {
                    ClearControls(panel, adgv);
                }
                else if (control is BsAdvDataGridView adg && adgv)
                {
                    adg.CleanFilterAndSort();
                    adg.ClearSelection();
                }
            }
        }

        public void ClearControls(bool adgv = true)
        {
            ClearControls(this, adgv);
        }

        #endregion ClearControls
    }
}