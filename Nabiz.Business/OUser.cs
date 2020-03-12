using Nabiz.Data.Model;
using System.Collections.Generic;

namespace Nabiz.Business
{
    public class OUserGet : BaseOperations<List<User>>
    {
        private readonly string _macAddress;

        public OUserGet(string macAddress = "")
        {
            _macAddress = macAddress;
        }

        protected override void DoJob()
        {
            string query;
            if (string.IsNullOrEmpty(_macAddress))
                query = "SELECT * FROM User";
            else
                query = string.Format("SELECT * FROM User WHERE MacAddress = '{0}'", _macAddress);

            OperationResult.Value = BaseRepository.BsGetList<User>(query);
        }
    }

    public class OUserSave : BaseOperationsDefault
    {
        private readonly string _macAddress;

        public OUserSave(string macAddress)
        {
            _macAddress = macAddress;
        }

        protected override void DoJob()
        {
            const string query = "INSERT INTO User (MacAddress, LastUpdated) VALUES (@MacAddress, @LastUpdated)";
            BaseRepository.BsExecute(query, new { MacAddress = _macAddress, LastUpdated = 23 });
        }
    }
}