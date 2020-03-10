using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class MdiContainer : Form
    {
        public UserForm UserForm { get; set; }

        public MdiContainer()
        {
            InitializeComponent();
            okTabBrowser.SetMdiForm(this);
        }

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
    }
}