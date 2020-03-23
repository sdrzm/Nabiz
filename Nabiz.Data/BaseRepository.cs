using Dapper;
using Dapper.Contrib.Extensions;
using Nabiz.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Nabiz.Data
{
    public class BaseRepository
    {
        //Türeyen sınıflar kullanacak
        public readonly SQLiteConnection BaseConnection;

        #region Constructors

        //Türeyen sınıflardan BaseOperation'da üretilen connection geliyor.
        protected BaseRepository(SQLiteConnection cnn) => BaseConnection = cnn;

        public BaseRepository() => BaseConnection = SimpleDbConnection();

        #endregion Constructors

        #region Private Methods

        /// <returns>Returns a new connection.</returns>
        private static SQLiteConnection SimpleDbConnection()
        {
            string dbFile = Environment.CurrentDirectory + "\\NabizDb.sqlite";
            return new SQLiteConnection("Data Source=" + dbFile);
        }

        //Foreign Key constrait activation.
        private void TurnOnConstraint()
        {
            BaseConnection.Execute("PRAGMA foreign_keys = ON;");
        }

        #endregion Private Methods

        #region DbOperations

        #region Dapper

        //Returns affected row number.
        public int BsExecute(string query, object param = null)
        {
            TurnOnConstraint();
            return BaseConnection.Execute(query, param);
        }

        public T BsGetOne<T>(string query, object param = null)
        {
            return BaseConnection.QueryFirstOrDefault<T>(query, param);
        }

        public List<T> BsGetList<T>(string query, object param = null)
        {
            return BaseConnection.Query<T>(query, param).AsList();
        }

        #endregion Dapper

        #region Contrib

        public T BsGetOneContrib<T>(object id) where T : class
        {
            return BaseConnection.Get<T>(id);
        }

        public List<T> BsGetAllContrib<T>() where T : class
        {
            return BaseConnection.GetAll<T>().AsList();
        }

        public long BsInsertContrib<T>(T obj) where T : BaseObject
        {
            obj.LastUpdated = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            return BaseConnection.Insert(obj);
        }

        public bool BsUpdateContrib<T>(T obj) where T : BaseObject
        {
            obj.LastUpdated = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            return BaseConnection.Update<T>(obj);
        }

        public bool BsDeleteSoftContrib<T>(T obj) where T : BaseObject
        {
            obj.LastUpdated = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            obj.Status = 0;
            return BaseConnection.Update<T>(obj);
        }

        public bool BsDeleteContrib<T>(T obj) where T : BaseObject
        {
            return BaseConnection.Delete(obj);
        }

        #endregion Contrib

        #endregion DbOperations
    }
}