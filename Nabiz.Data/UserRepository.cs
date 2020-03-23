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
                query = $"SELECT * FROM User WHERE Status = 1";
            else
                query = $"SELECT * FROM User WHERE MacAddress = '{macAddress}' AND Status = 1";

            return BsGetList<User>(query);
        }
    }
}