using Nabiz.Data.Model;
using System.Collections.Generic;

namespace Nabiz.Business
{
    public class OUserGet : BaseOperations<List<User>>
    {
        #region Private Fields

        private readonly string _macAddress;

        #endregion Private Fields

        #region Public Constructors

        public OUserGet(string macAddress = "") => _macAddress = macAddress;

        #endregion Public Constructors

        #region Protected Methods

        protected override void DoJob()
        {
            string query;
            if (string.IsNullOrEmpty(_macAddress))
                query = "SELECT * FROM User";
            else
                query = string.Format("SELECT * FROM User WHERE MacAddress = '{0}'", _macAddress);

            OperationResult.Value = BaseRepository.BsGetList<User>(query);
        }

        #endregion Protected Methods
    }

    public class OUserSave : BaseOperationsDefault
    {
        #region Fields

        private readonly User _obj;

        #endregion Fields

        #region Public Constructors

        public OUserSave(User obj) => _obj = obj;

        #endregion Public Constructors

        #region Protected Methods

        protected override void DoJob()
        {
            const string query = "INSERT INTO User (MacAddress, LastUpdated) VALUES (@MacAddress, @LastUpdated)";
            BaseRepository.BsExecute(query, new { _obj.MacAddress, LastUpdated = 23 });
        }

        #endregion Protected Methods
    }
}