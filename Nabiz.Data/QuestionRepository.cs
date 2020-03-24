using Nabiz.Data.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class QuestionRepository : BaseRepository
    {
        public QuestionRepository(SQLiteConnection cnn) : base(cnn)
        { }

        public List<Question> GetUsers(string text)
        {
            string query;
            if (string.IsNullOrEmpty(text))
                query = $"SELECT * FROM Question WHERE Status = 1";
            else
                query = $"SELECT * FROM User WHERE Text LIKE '%{text}%' AND Status = 1";

            return BsGetList<Question>(query);
        }
    }
}