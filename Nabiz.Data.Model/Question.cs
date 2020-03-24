using Dapper.Contrib.Extensions;

namespace Nabiz.Data.Model
{
    [Table("Question")]
    public class Question : BaseObject
    {
        public string Text { get; set; }
        public int ChoiceTypeId { get; set; }
        public int ChoiceGroupId { get; set; }
    }
}