using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsDataGridView : DataGridView
    {
        public BsDataGridView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

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

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!Columns.Contains("dummy"))
            {
                Columns.Add("dummy", "");
                int lastColIndex = Columns.Count - 1;
                var lastCol = Columns[lastColIndex];
                lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            foreach (DataGridViewColumn dataGridViewColumn in from DataGridViewColumn dgc in Columns
                                                              where dgc.Name.Contains("id") || dgc.Name.Contains("Id") || dgc.Name.Contains("ID") || dgc.Name.Contains("Status")
                                                              select dgc)
            {
                dataGridViewColumn.Visible = false;
            }
        }

        private void OkDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Columns.Contains("IsGreenVf")) return;
            foreach (DataGridViewRow row in Rows)
            {
                row.DefaultCellStyle.BackColor = (bool)row.Cells["IsGreenVf"].Value ? Color.Green : Color.Red;
            }
        }

        #endregion Private Methods

        #region Public Methods

        public void BsDataSourceList<T>(IEnumerable<T> List)
        {
            DataSource = ConvertToDatatable(List);
        }

        public T DataRowToObject<T>(DataGridViewRow gridRow) where T : class, new()
        {
            T obj = new T();

            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                propertyInfo.SetValue(obj, Convert.ChangeType(gridRow.Cells[prop.Name].Value, propertyInfo.PropertyType), null);
            }

            return obj;
        }

        #endregion Public Methods
    }
}