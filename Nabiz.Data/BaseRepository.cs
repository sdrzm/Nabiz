using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class BaseRepository
    {
        #region Protected Fields

        //Türeyen sınıflar kullanacak
        protected readonly SQLiteConnection BaseConnection;

        #endregion Protected Fields

        #region Public Constructors

        //Türeyen sınıflardan BaseOperation'da üretilen connection geliyor.
        public BaseRepository(SQLiteConnection cnn) => BaseConnection = cnn;

        #endregion Public Constructors

        #region Public Methods

        /// <returns>Returns a new connection.</returns>
        public static SQLiteConnection SimpleDbConnection()
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

        public void BsExecuteWithDefaultParameters(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            BaseConnection.Execute(query, param);
        }

        public List<T> BsGetList<T>(string query, object param = null)
        {
            //Foreign Key constrait activation.
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
            return BaseConnection.Query<T>(query, param).AsList();
        }

        #endregion Public Methods
    }
}