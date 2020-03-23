using Dapper.Contrib.Extensions;

namespace Nabiz.Data.Model
{
    public class BaseObject
    {
        [Key]
        public int Guid { get; set; }

        public int Status { get; set; } = 1;
        public long LastUpdated { get; set; }
    }
}