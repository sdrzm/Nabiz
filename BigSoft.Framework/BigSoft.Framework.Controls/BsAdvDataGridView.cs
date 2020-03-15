using System;
using System.ComponentModel;
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

        private void BsAdvDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            CurrentGridRow = ((DataGridView)sender).CurrentRow;
        }

        #endregion Events

        #region Public Methods

        public T DataRowToObject<T>(DataGridViewRow gridRow) where T : class, new()
        {
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