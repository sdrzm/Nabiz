using System.Data.SQLite;

namespace Nabiz.Data
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        //public List<Magazine> GetList()
        //{
        //    using (var cnn = SimpleDbConnection())
        //    {
        //        cnn.Open();
        //        const string query = "SELECT * FROM Magazine ORDER BY MagazineName COLLATE NOCASE";
        //        return cnn.Query<Magazine>(query).AsList();
        //    }
        //}
    }
}