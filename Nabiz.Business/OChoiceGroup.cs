using Nabiz.Data.Model;
using System.Collections.Generic;

namespace Nabiz.Business
{
    public class OChoiceGroupGet : BaseOperation<List<ChoiceGroup>>
    {
        protected override void DoJob()
        {
            BsOpResult.Value = BsRepository.BsGetAllContrib<ChoiceGroup>();
        }
    }
}