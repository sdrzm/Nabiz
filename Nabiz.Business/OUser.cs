namespace Nabiz.Business
{
    public class OUserSave : BaseOperations
    {
        private readonly string _macAddress;

        public OUserSave(string macAddress)
        {
            _macAddress = macAddress;
        }

        protected override void DoJob()
        {
            const string query = "INSERT INTO User (MacAddress, LastUpdated) VALUES (@MacAddress, @LastUpdated)";
            BaseRepository.BsExecute(query, new { MacAddress = _macAddress, LastUpdated = 23 });
        }
    }
}