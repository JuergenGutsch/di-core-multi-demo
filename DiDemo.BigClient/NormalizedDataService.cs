using DiDemo.CsvFileConnector;
using DiDemo.SqlDatabaseConnector;

namespace DiDemo.BigClient
{
    public class NormalizedDataService : INormalizedDataService
    {
        private readonly ICsvDataService _csvDataService;
        private readonly ISqlDataService _sqlDataService;

        public NormalizedDataService(ICsvDataService csvDataService, ISqlDataService sqlDataService)
        {
            _csvDataService = csvDataService;
            _sqlDataService = sqlDataService;
        }

        public object GetNormalizedData()
        {
            return $"{_csvDataService.GetData()}\n{_sqlDataService.GetData()}";
        }
    }
    public interface INormalizedDataService
    {
        object GetNormalizedData();
    }
}
