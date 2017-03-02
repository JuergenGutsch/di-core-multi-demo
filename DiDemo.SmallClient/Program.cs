using DiDemo.CsvFileConnector;
using DiDemo.SmallClient;
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

        var provider = services.BuildServiceProvider();

        var writer = provider.GetService<IWriteSimpleDataService>();
        writer.write();

        Console.ReadLine();
    }
}