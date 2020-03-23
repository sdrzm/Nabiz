using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsFormGrid : BsForm
    {
        public BsFormGrid() => InitializeComponent();

        #region Events

        private void BsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            BsToolStripStatusLabel.Text = string.Format("Toplam Kayıt: {0}", BsBindingSource.List.Count.ToString());
        }

        private void BsStandartToolStrip_BsSaveButtonClicked(object sender, System.EventArgs e)
        {
            CheckValidation(this);
        }

        #endregion Events

        private static DataTable ConvertToDatatable<T>(IEnumerable<T> source, params string[] members)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(source, members))
            {
                table.Load(reader);
            }
            return table;
        }

        public void BindDataAsList<T>(IEnumerable<T> list)
        {
            BsBindingSource.DataSource = ConvertToDatatable(list);
            BsAdgv.DataSource = BsBindingSource;
        }

        public T DataRowToObject<T>(DataGridViewSelectedRowCollection selectedRows) where T : class, new()
        {
            if (selectedRows.Count == 0)
                return null;

            T obj = new T();

            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                propertyInfo.SetValue(obj, Convert.ChangeType(selectedRows[0].Cells[prop.Name].Value, propertyInfo.PropertyType));
            }

            return obj;
        }
    }
}