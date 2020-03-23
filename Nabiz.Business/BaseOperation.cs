using BigSoft.Framework.Util;
using Nabiz.Data;
using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Nabiz.Business
{
    public abstract class BaseOperation<T> where T : class
    {
        protected BsOpResult<T> BsOpResult = new BsOpResult<T>();
        protected BaseRepository BsRepository { get; set; } = new BaseRepository();

        protected abstract void DoJob();

        public BsOpResult<T> Execute([CallerMemberName] string metod = "", [CallerLineNumber] int satir = -1)
        {
            try
            {
                SQLiteConnection BsConnection = BsRepository.BaseConnection;

                using (BsRepository.BaseConnection)
                {
                    BsConnection.Open();
                    SQLiteTransaction tran = BsConnection.BeginTransaction();
                    BsTrace.LogInfo(string.Format("Caller Method: {0}, Line: {1}", metod, satir));

                    DoJob();
                    tran.Commit();

                    if (BsOpResult.ResultType == ResultType.Successful)
                        BsOpResult.Message = "Başarıyla tamamlandı";
                }
            }
            catch (BsException ex)
            {
                BsOpResult.Message = ex.Message;
                BsOpResult.ResultType = ResultType.UserError;
                BsTrace.LogException(ex, ResultType.UserError);
            }
            catch (Exception ex)
            {
                BsOpResult.Message = ex.Message;
                BsOpResult.ResultType = ResultType.SystemError;
                BsTrace.LogException(ex, ResultType.SystemError);
            }

            return BsOpResult;
        }
    }

    public abstract class BaseOperationDefault : BaseOperation<string>
    {
    }
}