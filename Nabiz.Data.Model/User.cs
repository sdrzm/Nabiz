using Dapper.Contrib.Extensions;

namespace Nabiz.Data.Model
{
    [Table("User")]
    public class User : BaseObject
    {
        //[ExplicitKey]
        public string MacAddress { get; set; }
    }
}