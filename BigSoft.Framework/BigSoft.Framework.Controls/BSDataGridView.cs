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
                                                              where dgc.Name.Contains("id") || dgc.Name.Contains("Id") || dgc.Name.Contains("ID") || dgc.Name.Contains("Status") || dgc.Name.Contains("Vf")
                                                              select dgc)
            {
                dataGridViewColumn.Visible = false;
            }
        }

        private void OkDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CurrentGridRow = ((DataGridView)sender).CurrentRow;
        }

        public void SetDataSource<T>(IEnumerable<T> data)
        {
            //PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));


            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties();

            DataTable table = new DataTable();
            foreach (PropertyInfo prop in propertyInfos)
            {
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[propertyInfos.Length];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyInfos[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            DataSource = table;
        }

        public T DataRowToObject<T>(DataGridViewRow gridRow) where T : class, new()
        {
            //List<T> list = new List<T>();
            T obj = new T();

            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                propertyInfo.SetValue(obj, Convert.ChangeType(gridRow.Cells[prop.Name].Value, propertyInfo.PropertyType), null);
            }

            //list.Add(obj);
            return obj;
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
