using BigSoft.Framework.Util;
using Nabiz.Data;
using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Nabiz.Business
{
    public abstract class BaseOperations<T> where T : class
    {
        #region Protected Fields

        protected BsOpResult<T> OperationResult = new BsOpResult<T>();

        #endregion Protected Fields

        #region Protected Properties

        protected BaseRepository BaseRepository { get; set; }
        protected SQLiteConnection SQLiteConnection { get; set; }

        #endregion Protected Properties

        #region Protected Methods

        protected abstract void DoJob();

        #endregion Protected Methods

        #region Public Methods

        public BsOpResult<T> Execute([CallerMemberName] string metod = "", [CallerLineNumber] int satir = -1)
        {
            try
            {
                SQLiteConnection = BaseRepository.SimpleDbConnection();
                BaseRepository = new BaseRepository(SQLiteConnection);

                using (SQLiteConnection)
                {
                    SQLiteConnection.Open();
                    SQLiteTransaction tran = SQLiteConnection.BeginTransaction();
                    BsTrace.LogInfo(string.Format("Caller Method: {0}, Line: {1}", metod, satir));

                    DoJob();
                    tran.Commit();

                    if (OperationResult.IsSuccessful == Success.Successful)
                        OperationResult.Message = "Başarıyla tamamlandı";
                }
            }
            catch (BsException ex)
            {
                BsTrace.LogException(ex, ex.GetType().Name);

                OperationResult.Message = ex.Message;
                OperationResult.IsSuccessful = ex.BsResult;
            }
            catch (Exception ex)
            {
                OperationResult.Message = ex.Message;
                OperationResult.IsSuccessful = Success.SystemError;
                OperationResult.Exception = ex.InnerException;
                BsTrace.LogException(ex, ex.Message);
            }

            return OperationResult;
        }

        #endregion Public Methods
    }

    public abstract class BaseOperationsDefault : BaseOperations<string>
    {
    }
}