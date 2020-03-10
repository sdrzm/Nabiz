using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsTextBox : TextBox
    {
        [Category("OkProperties"), DefaultValue(false)]
        public bool IsNumeric { get; set; }

        [Category("OkProperties"), DefaultValue(false)]
        public bool IsMoneyBox { get; set; }

        [Category("OkProperties"), DefaultValue(false)]
        public bool ThousandSeparator { get; set; }

        public BsTextBox()
        {
            InitializeComponent();
        }

        public BsTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsNumeric)
                return;
            base.OnKeyPress(e);

            if ((Char.IsDigit(e.KeyChar) || e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public int GetInt32()
        {
            int value;
            string text = Text.Replace(".", "");

            Int32.TryParse(text, out value);
            return value;
        }

        public decimal GetDecimal()
        {
            decimal result;
            string text = Text.Replace(".", "");
            
            Decimal.TryParse(text, NumberStyles.Currency, CultureInfo.CurrentCulture, out result);
            return result;
        }

        private void OkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric && ThousandSeparator && !String.IsNullOrEmpty(Text) && !IsMoneyBox)
            {
                Text = Decimal.Parse(Text, NumberStyles.Currency ).ToString("N0");
            }

            //SelectionStart = Text.Length;
            //SelectionLength = 0;
        }
    }
}
