using System;

namespace DiDemo.BigClient
{
    public class WriteExtendedDataService : IWriteExtendedDataService
    {
        private readonly INormalizedDataService _normalizedDataService;

        public WriteExtendedDataService(INormalizedDataService normalizedDataService)
        {
            _normalizedDataService = normalizedDataService;
        }

        public void write()
        {
            var data = _normalizedDataService.GetNormalizedData();
            Console.WriteLine(data);
        }
    }
    public interface IWriteExtendedDataService
    {
        void write();
    }
}
