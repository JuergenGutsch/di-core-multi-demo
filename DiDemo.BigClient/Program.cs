using DiDemo.BigClient;
using DiDemo.CsvFileConnector;
using DiDemo.SqlDatabaseConnector;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var services = new ServiceCollection();
        services.AddInternalServices();
        services.AddCsvFileConnector();
        services.AddSqlDatabaseConnector();

        var provider = services.BuildServiceProvider();

        var writer = provider.GetService<IWriteExtendedDataService>();
        writer.write();

        Console.ReadLine();
    }
}