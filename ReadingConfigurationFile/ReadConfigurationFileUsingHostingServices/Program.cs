// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "config.json";

IHost host = Host.CreateDefaultBuilder().ConfigureAppConfiguration((hostingContext, config) =>
{
    // Specify the path to your configuration file
    config.AddJsonFile(path, optional: false, reloadOnChange: true);
})
    .Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

Console.WriteLine(config.GetValue<string>("browser"));
Console.WriteLine(config.GetValue<string>("build"));
Console.WriteLine(config.GetValue<string>("language"));

await host.RunAsync();
