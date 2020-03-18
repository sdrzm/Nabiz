using BigSoft.Framework.Util;
using Nabiz.Data;
using Nabiz.Data.Model;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Nabiz.Business
{
    public static class OUser
    {
        public static void CheckExitence(User obj, SQLiteConnection cnn)
        {
            if (string.IsNullOrEmpty(obj.MacAddress))
                throw new BsException("Boş girilemez");

            UserRepository repo = new UserRepository(cnn);
            List<User> list = repo.GetUsers(obj.MacAddress);

            if (list.Any(i => i.MacAddress == obj.MacAddress))
                throw new BsException("Zaten mevcut kayıt");
        }
    }

    public class OUserGet : BaseOperation<List<User>>
    {
        private readonly string _macAddress;

        public OUserGet(string macAddress = "") => _macAddress = macAddress;

        protected override void DoJob()
        {
            UserRepository repo = new UserRepository(BsConnection);
            BsOpResult.Value = repo.GetUsers(_macAddress);
        }
    }

    public class OUserSave : BaseOperationDefault
    {
        private readonly User _obj;

        public OUserSave(User obj) => _obj = obj;

        protected override void DoJob()
        {
            OUser.CheckExitence(_obj, BsConnection);

            const string query = "INSERT INTO User (MacAddress, LastUpdated) VALUES (@MacAddress, @LastUpdated)";
            BsRepository.BsExecute(query, new { _obj.MacAddress, LastUpdated = 23 });
        }
    }
}