using System;

namespace BigSoft.Framework.Controls
{
    public interface IBsMappable
    {
        #region Public Properties

        string BsDataClassName { get; set; }
        string BsDataFieldName { get; set; }

        #endregion Public Properties

        #region Public Methods

        object GetValue(Type type);

        void SetValue(object value);

        #endregion Public Methods
    }

    public interface IBsValidatable
    {
        #region Public Properties

        bool BsValidatable { get; set; }

        #endregion Public Properties

        #region Public Methods

        bool IsValueValid();

        void ClearErrorProvider();

        void SetErrorProvider();

        #endregion Public Methods
    }
}