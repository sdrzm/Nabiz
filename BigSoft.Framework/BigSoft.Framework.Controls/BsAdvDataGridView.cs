using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Zuby.ADGV;

namespace BigSoft.Framework.Controls
{
    [Designer(typeof(ControlDesigner))]
    public partial class BsAdvDataGridView : AdvancedDataGridView
    {
        #region Public Constructors

        public BsAdvDataGridView() => InitializeComponent();

        #endregion Public Constructors

        #region Events

        private static bool CheckColumns(DataGridViewColumn c)
        {
            string name = c.Name.ToLower();
            return name.Contains("id") || name.Contains("ıd") || name.Contains("lastupdated")
                || name.Contains("status");
        }

        private static Func<DataGridViewColumn, bool> MakeColumnsUnvisible()
        {
            return CheckColumns;
        }

        private void BsAdvDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Func<DataGridViewColumn, bool> predicate = i => i.Name.Contains("id");
            foreach (var item in Columns.Cast<DataGridViewColumn>().Where(MakeColumnsUnvisible()).ToList())
            {
                item.Visible = false;
            }
            ClearSelection();
        }

        #endregion Events
    }
}