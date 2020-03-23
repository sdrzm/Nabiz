using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsTextBox : TextBox, IBsMappable, IBsValidatable
    {
        #region Public Properties

        [Category("BsControls")]
        [DefaultValue("")]
        public string BsDataClassName { get; set; }

        [Category("BsControls")]
        [DefaultValue("")]
        public string BsDataFieldName { get; set; }

        [Category("BsControls"), DefaultValue(false)]
        public bool IsMoneyBox { get; set; }

        [Category("BsControls"), DefaultValue(false)]
        public bool IsNumeric { get; set; }

        [Category("BsControls"), DefaultValue(false)]
        public bool ThousandSeparator { get; set; }

        [Category("BsControls"), DefaultValue(false)]
        public bool BsValidatable { get; set; }

        #endregion Public Properties

        #region Public Constructors

        public BsTextBox() => InitializeComponent();

        public BsTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void OkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric && ThousandSeparator && !String.IsNullOrEmpty(Text) && !IsMoneyBox)
            {
                Text = Decimal.Parse(Text, NumberStyles.Currency).ToString("N0");
            }
        }

        #endregion Private Methods

        #region Protected Methods

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsNumeric)
                return;
            base.OnKeyPress(e);

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        #endregion Protected Methods

        #region Public Methods

        public decimal GetDecimal()
        {
            string text = Text.Replace(".", "");

            decimal.TryParse(text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal result);
            return result;
        }

        public int GetInt32()
        {
            string text = Text.Replace(".", "");

            int.TryParse(text, out int value);
            return value;
        }

        public object GetValue(Type type)
        {
            if (type == typeof(string))
                return Text;
            else if (type == typeof(short))
                return Convert.ToInt16(Text);
            else if (type == typeof(int))
                return Convert.ToInt32(Text);
            else if (type == typeof(long))
                return Convert.ToInt64(Text);
            else
                return null;
        }

        public void SetValue(object value)
        {
            if (value is string x)
                Text = x;
            else if (value is short || value is int || value is long)
                Text = Convert.ToString(value);
        }

        #endregion Public Methods
    }
}