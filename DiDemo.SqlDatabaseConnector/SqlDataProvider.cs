namespace DiDemo.SqlDatabaseConnector
{
    public class SqlDataProvider : ISqlDataProvider
    {
        public string Fetch()
        {
            return "Hello from within the SqlDataProvider";
        }
    }

    public interface ISqlDataProvider
    {
        string Fetch();
    }
}
