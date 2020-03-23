using System;
using System.ComponentModel;
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
        public bool BsValidatable { get; set; }

        public short BsShort
        {
            get
            {
                if (string.IsNullOrEmpty(Text.Trim()))
                    return 0;
                else
                    return Convert.ToInt16(Text);
            }
            set { Text = value.ToString(); }
        }

        public int BsInt
        {
            get
            {
                if (string.IsNullOrEmpty(Text.Trim()))
                    return 0;
                else
                    return Convert.ToInt32(Text);
            }
            set { Text = value.ToString(); }
        }

        public long BsLong
        {
            get
            {
                if (string.IsNullOrEmpty(Text.Trim()))
                    return 0;
                else
                    return Convert.ToInt16(Text);
            }
            set { Text = value.ToString(); }
        }

        #endregion Public Properties

        #region Public Constructors

        public BsTextBox() => InitializeComponent();

        public BsTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion Public Constructors

        public object GetValue(Type type)
        {
            if (type == typeof(string))
                return Text;
            else if (type == typeof(short))
                return BsShort;
            else if (type == typeof(int))
                return BsInt;
            else if (type == typeof(long))
                return BsLong;
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
    }
}