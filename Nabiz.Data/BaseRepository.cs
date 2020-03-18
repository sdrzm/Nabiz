using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class BaseRepository
    {
        //Türeyen sınıflar kullanacak
        public readonly SQLiteConnection BaseConnection;

        //Türeyen sınıflardan BaseOperation'da üretilen connection geliyor.
        protected BaseRepository(SQLiteConnection cnn) => BaseConnection = cnn;

        public BaseRepository() => BaseConnection = SimpleDbConnection();

        /// <returns>Returns a new connection.</returns>
        private static SQLiteConnection SimpleDbConnection()
        {
            string dbFile = Environment.CurrentDirectory + "\\NabizDb.sqlite";
            return new SQLiteConnection("Data Source=" + dbFile);
        }

        /// <returns>Returns affected row number.</returns>
        public int BsExecute(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            return BaseConnection.Execute(query, param);
        }

        public List<T> BsGetList<T>(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            return BaseConnection.Query<T>(query, param).AsList();
        }
    }
}