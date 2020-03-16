using BigSoft.Framework.Util;
using FastMember;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsFormGrid : BsForm
    {
        #region Public Properties

        public BsOpResultBase OpResult { get; set; } = new BsOpResultBase();

        #endregion Public Properties

        #region Public Constructors

        public BsFormGrid() => InitializeComponent();

        #endregion Public Constructors

        #region Events

        private void BsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            BsToolStripStatusLabel.Text = string.Format("Toplam Kayıt: {0}", BsBindingSource.List.Count.ToString());
        }

        #endregion Events

        #region Private Methods

        private static DataTable ConvertToDatatable<T>(IEnumerable<T> source, params string[] members)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(source, members))
            {
                table.Load(reader);
            }
            return table;
        }

        #endregion Private Methods

        #region Public Methods

        public void BindDataAsList<T>(IEnumerable<T> list)
        {
            BsBindingSource.DataSource = ConvertToDatatable(list);
            BsAdgv.DataSource = BsBindingSource;
        }

        #endregion Public Methods

        private void CheckValidation(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is IBsValidatable cctrl && cctrl.BsValidatable && cctrl is TextBox box)
                {
                    if (string.IsNullOrEmpty(box.Text))
                    {
                        box.BackColor = Color.MistyRose;
                        OpResult.IsSuccessful = Success.UserError;
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

        private void BsStandartToolStrip_BsSaveButtonClicked(object sender, System.EventArgs e)
        {
            CheckValidation(this);
        }
    }
}