using BigSoft.Framework.Util;
using Nabiz.Data;
using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Nabiz.Business
{
    public abstract class BaseOperations
    {
        protected BsOperationResult OperationResult { get; set; } = new BsOperationResult();
        protected BaseRepository BaseRepository { get; set; }
        protected SQLiteConnection SQLiteConnection { get; set; }

        public BsOperationResult Execute([CallerMemberName] string metod = "", [CallerLineNumber] int satir = -1)
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

                    if (OperationResult.BsResult == BsResult.Successful)
                        OperationResult.Message = "Başarıyla tamamlandı";
                }
            }
            catch (BsException ex)
            {
                BsTrace.LogException(ex, ex.GetType().Name);

                OperationResult.Message = ex.Message;
                OperationResult.BsResult = ex.BsResult;
            }
            catch (Exception ex)
            {
                OperationResult.Message = ex.Message;
                OperationResult.BsResult = BsResult.SystemError;
                OperationResult.Exception = ex.InnerException;
                BsTrace.LogException(ex, ex.Message);
            }

            return OperationResult;
        }

        protected abstract void DoJob();
    }
}