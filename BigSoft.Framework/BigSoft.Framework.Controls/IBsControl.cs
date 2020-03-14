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
}