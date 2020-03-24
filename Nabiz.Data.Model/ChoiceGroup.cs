using Dapper.Contrib.Extensions;

namespace Nabiz.Data.Model
{
    [Table("ChoiceGroup")]
    public class ChoiceGroup : BaseObject
    {
        public string ChoiceGroupName { get; set; }
    }
}