namespace DiDemo.SqlDatabaseConnector
{
    public class SqlDataService : ISqlDataService
    {
        private readonly ISqlDataProvider _provider;

        public SqlDataService(ISqlDataProvider provider)
        {
            _provider = provider;
        }

        public string GetData()
        {
            return _provider.Fetch();
        }
    }
    public interface ISqlDataService
    {
        string GetData();
    }

}
