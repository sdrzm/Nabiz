using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public class BsForm : Form
    {
        private void CloseTab()
        {
            Form form = this;
            if (Parent == null) return;
            foreach (BsTabBrowser c in Parent.Parent.Controls.OfType<BsTabBrowser>())
            {
                c.DisposeTabPage(form);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CloseTab();
            base.OnClosing(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            BsStandartToolStrip toolStrip = Controls.OfType<BsStandartToolStrip>().FirstOrDefault();
            List<TextBox> textBoxes = Controls.OfType<TextBox>().ToList();
            switch (keyData)
            {
                case (Keys.Control | Keys.S):
                    if (toolStrip.OkSaveButtonEnabled)
                        toolStrip.TsbSave_Click_1(null, null);
                    return true;

                case Keys.Delete:
                    if (textBoxes.Any(a => a.Focused))
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                    else if (toolStrip.OkDeleteButtonEnabled)
                    {
                        toolStrip.TsbDelete_Click_1(null, null);
                        return true;
                    }
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public interface IBsForm<T>
    {
        T FillObject();

        void FillScreen(T obj);
    }
}