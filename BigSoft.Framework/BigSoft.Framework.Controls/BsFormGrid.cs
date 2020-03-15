using FastMember;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BigSoft.Framework.Controls
{
    public partial class BsFormGrid : BsForm
    {
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
    }
}