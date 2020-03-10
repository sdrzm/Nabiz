using System.ComponentModel;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsListView : ListView
    {
        public BsListView()
        {
            InitializeComponent();
        }

        public BsListView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void GenerateListView(int columnCount)
        {
            FullRowSelect = true;
            GridLines = true;
            View = View.Details;
            HeaderStyle = ColumnHeaderStyle.None;
            MultiSelect = false;

            for (int i = 0; i < columnCount; i++)
            {
                Columns.Add(i.ToString());
                Columns[i].Width = -2;
            }
            //Scrollable = false;
        }
    }
}