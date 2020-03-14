using System;
using System.Reflection;
using System.Windows.Forms;
using Zuby.ADGV;

namespace BigSoft.Framework.Controls
{
    public partial class BsAdvDataGridView : AdvancedDataGridView
    {
        #region Public Constructors

        public DataGridViewRow CurrentGridRow { get; private set; }

        public BsAdvDataGridView()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void BsAdvDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            CurrentGridRow = ((DataGridView)sender).CurrentRow;
        }

        #endregion Private Methods

        #region Public Methods

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