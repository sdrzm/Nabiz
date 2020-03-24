using BigSoft.Framework.Util;
using Nabiz.Data;
using Nabiz.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Nabiz.Business
{
    //public static class OUser
    //{
    //    public static void CheckExistence(User obj, BaseRepository baseRepo)
    //    {
    //        if (string.IsNullOrEmpty(obj.MacAddress))
    //            throw new BsException("Boş girilemez");

    //        UserRepository userRepo = new UserRepository(baseRepo.BaseConnection);
    //        List<User> list = userRepo.GetUsers(obj.MacAddress);

    //        if (list.Any(i => i.MacAddress == obj.MacAddress))
    //            throw new BsException("Zaten mevcut kayıt");
    //    }
    //}

    public class OQuestionGet : BaseOperation<List<Question>>
    {
        private readonly string _text;
        public List<ChoiceType> ChoiceTypes;
        public List<ChoiceGroup> ChoiceGroup;

        public OQuestionGet(string text = "") => _text = text;

        protected override void DoJob()
        {
            ChoiceGroup = BsRepository.BsGetAllContrib<ChoiceGroup>();
            ChoiceTypes = BsRepository.BsGetAllContrib<ChoiceType>();

            QuestionRepository repo = new QuestionRepository(BsRepository.BaseConnection);
            BsOpResult.Value = repo.GetUsers(_text);
        }
    }

    //public class OUserSave : BaseOperationDefault
    //{
    //    private readonly User _obj;

    //    public OUserSave(User obj) => _obj = obj;

    //    protected override void DoJob()
    //    {
    //        OUser.CheckExistence(_obj, BsRepository);
    //        BsRepository.BsInsertContrib(_obj);
    //    }
    //}

    //public class OUserUpdate : BaseOperationDefault
    //{
    //    private readonly User _obj;

    //    public OUserUpdate(User obj) => _obj = obj;

    //    protected override void DoJob()
    //    {
    //        OUser.CheckExistence(_obj, BsRepository);
    //        BsRepository.BsUpdateContrib(_obj);
    //    }
    //}

    //public class OUserDelete : BaseOperationDefault
    //{
    //    private readonly User _obj;

    //    public OUserDelete(User obj) => _obj = obj;

    //    protected override void DoJob()
    //    {
    //        BsRepository.BsDeleteSoftContrib(_obj);
    //    }
    //}
}