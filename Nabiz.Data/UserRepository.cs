using Nabiz.Data.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(SQLiteConnection cnn) : base(cnn)
        { }

        public List<User> GetUsers(string macAddress)
        {
            string query;
            if (string.IsNullOrEmpty(macAddress))
            {
                return BsGetAllContrib<User>();
            }
            else
            {
                query = string.Format("SELECT * FROM User WHERE MacAddress = '{0}'", macAddress);
                return BsGetList<User>(query);
            }
        }
    }
}