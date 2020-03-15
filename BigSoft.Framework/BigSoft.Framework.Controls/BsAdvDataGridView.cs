using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Zuby.ADGV;

namespace BigSoft.Framework.Controls
{
    [Designer(typeof(ControlDesigner))]
    public partial class BsAdvDataGridView : AdvancedDataGridView
    {
        #region Public Properties

        public DataGridViewRow CurrentGridRow { get; private set; }

        #endregion Public Properties

        #region Public Constructors

        public BsAdvDataGridView() => InitializeComponent();

        #endregion Public Constructors

        #region Events

        private static bool Check(DataGridViewColumn c)
        {
            string name = c.Name.ToLower();
            return name.Contains("id") || name.Contains("ıd") || name.Contains("lastupdated")
                || name.Contains("status");
        }

        private static Func<DataGridViewColumn, bool> CheckColumnName()
        {
            return Check;
        }

        private void BsAdvDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Func<DataGridViewColumn, bool> predicate = i => i.Name.Contains("id");
            foreach (var item in Columns.Cast<DataGridViewColumn>().Where(CheckColumnName()).ToList())
            {
                item.Visible = false;
            }
        }

        private void BsAdvDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            CurrentGridRow = ((DataGridView)sender).CurrentRow;
        }

        #endregion Events

        #region Public Methods

        public T DataRowToObject<T>(DataGridViewRow gridRow) where T : class, new()
        {
            if (gridRow == null)
                return null;

            T obj = new T();

            foreach (var prop in obj.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                propertyInfo.SetValue(obj, Convert.ChangeType(gridRow.Cells[prop.Name].Value, propertyInfo.PropertyType));
            }

            return obj;
        }

        #endregion Public Methods
    }
}