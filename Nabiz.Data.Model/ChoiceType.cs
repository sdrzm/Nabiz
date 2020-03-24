using Dapper.Contrib.Extensions;

namespace Nabiz.Data.Model
{
    [Table("ChoiceType")]
    public class ChoiceType : BaseObject
    {
        public string ChoiceTypeName { get; set; }
    }
}