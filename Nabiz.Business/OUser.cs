using BigSoft.Framework.Util;
using Nabiz.Data;
using Nabiz.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Nabiz.Business
{
    public static class OUser
    {
        public static void CheckExistence(User obj, BaseRepository baseRepo)
        {
            if (string.IsNullOrEmpty(obj.MacAddress))
                throw new BsException("Boş girilemez");

            UserRepository userRepo = new UserRepository(baseRepo.BaseConnection);
            List<User> list = userRepo.GetUsers(obj.MacAddress);

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
            UserRepository userRepo = new UserRepository(BsRepository.BaseConnection);
            BsOpResult.Value = userRepo.GetUsers(_macAddress);
        }
    }

    public class OUserSave : BaseOperationDefault
    {
        private readonly User _obj;

        public OUserSave(User obj) => _obj = obj;

        protected override void DoJob()
        {
            OUser.CheckExistence(_obj, BsRepository);
            BsRepository.BsInsertContrib(_obj);
        }
    }

    public class OUserUpdate : BaseOperationDefault
    {
        private readonly User _obj;

        public OUserUpdate(User obj) => _obj = obj;

        protected override void DoJob()
        {
            OUser.CheckExistence(_obj, BsRepository);
            BsRepository.BsInsertContrib(_obj);
        }
    }
}