using Nabiz.Data.Model;
using System.Collections.Generic;

namespace Nabiz.Business
{
    public class OChoiceTypeGet : BaseOperation<List<ChoiceType>>
    {
        protected override void DoJob()
        {
            BsOpResult.Value = BsRepository.BsGetAllContrib<ChoiceType>();
        }
    }
}