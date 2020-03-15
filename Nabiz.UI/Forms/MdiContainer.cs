using Nabiz.UI.Forms;
using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class MdiContainer : Form
    {
        #region Public Properties

        public UserForm UserForm { get; set; }

        #endregion Public Properties

        #region Public Constructors

        public MdiContainer()
        {
            InitializeComponent();
            okTabBrowser.SetMdiForm(this);
        }

        #endregion Public Constructors

        #region Private Methods

        private void MenuUser_Click(object sender, System.EventArgs e)
        {
            if (UserForm?.IsDisposed != false)
            {
                UserForm = new UserForm { MdiParent = this };
                UserForm.Show();
            }
            else
            {
                UserForm.Activate();
            }
        }

        #endregion Private Methods
    }
}