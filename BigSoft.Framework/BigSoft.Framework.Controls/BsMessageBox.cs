﻿using BigSoft.Framework.Util;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public static class BsMessageBox
    {
        #region Public Methods

        public static void Show(BsOpResultBase result)
        {
            switch (result.ResultType)
            {
                case ResultType.Successful:
                    MessageBox.Show(result.Message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case ResultType.UserError:
                    MessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case ResultType.SystemError:
                    MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Ask(string message)
        {
            return MessageBox.Show(message, "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion Public Methods
    }
}