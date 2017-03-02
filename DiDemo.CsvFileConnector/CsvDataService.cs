namespace DiDemo.CsvFileConnector
{
    public class CsvDataService : ICsvDataService
    {
        public string GetData()
        {
            return "Hello from CsvDataService";
        }
    }
    public interface ICsvDataService
    {
        string GetData();
    }
}
