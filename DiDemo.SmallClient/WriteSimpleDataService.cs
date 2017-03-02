using DiDemo.CsvFileConnector;
using System;

namespace DiDemo.SmallClient
{
    public class WriteSimpleDataService : IWriteSimpleDataService
    {
        private readonly ICsvDataService _csvDataService;

        public WriteSimpleDataService(ICsvDataService csvDataService)
        {
            _csvDataService = csvDataService;
        }

        public void write()
        {
            var data = _csvDataService.GetData();
            Console.WriteLine(data);
        }
    }
    public interface IWriteSimpleDataService
    {
        void write();
    }
}
