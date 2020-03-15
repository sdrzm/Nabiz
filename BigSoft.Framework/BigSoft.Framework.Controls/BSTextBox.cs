using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace BigSoft.Framework.Controls
{
    public partial class BsTextBox : TextBox, IBsMappable
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

        #endregion Public Properties

        #region Public Constructors

        public BsTextBox()
        {
            InitializeComponent();
        }

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
            return Text;
        }

        public void SetValue(object value)
        {
            if (value != null)
            {
                Text = (string)value;
            }
        }

        #endregion Public Methods
    }
}