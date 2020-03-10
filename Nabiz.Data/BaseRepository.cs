using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class BaseRepository
    {
        //türeyen sınıflar kullanacak
        protected readonly SQLiteConnection BaseConnection;

        //Türeyen sınıflardan BaseOperation'da üretilen connection geliyor.
        public BaseRepository(SQLiteConnection cnn)
        {
            BaseConnection = cnn;
        }

        //Returns a new connection.
        public static SQLiteConnection SimpleDbConnection()
        {
            string dbFile = Environment.CurrentDirectory + "\\NabizDb.sqlite";
            return new SQLiteConnection("Data Source=" + dbFile);
        }

        public List<T> BsGetList<T>(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            return BaseConnection.Query<T>(query, param).AsList();
        }

        /// <returns>
        /// The sum of two integers.
        /// </returns>
        public int BsExecute(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            return BaseConnection.Execute(query, param);
        }

        public void BsExecuteWithDefaultParameters(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            BaseConnection.Execute(query, param);
        }
    }
}