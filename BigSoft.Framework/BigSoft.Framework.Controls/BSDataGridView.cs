using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsDataGridView : DataGridView
    {
        public DataGridViewRow CurrentGridRow { get; set; }

        public BsDataGridView()
        {
            InitializeComponent();
        }

        public BsDataGridView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
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

        private void OkDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CurrentGridRow = ((DataGridView)sender).CurrentRow;
        }

        private void OkDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!Columns.Contains("IsGreenVf")) return;
            foreach (DataGridViewRow row in Rows)
            {
                row.DefaultCellStyle.BackColor = (bool)row.Cells["IsGreenVf"].Value ? Color.Green : Color.Red;
            }
        }
    }
}