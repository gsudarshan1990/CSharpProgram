// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "appsettings.json";
ConfigurationBuilder builder = new ConfigurationBuilder();


IHost host = Host.CreateDefaultBuilder().ConfigureAppConfiguration((builder) =>
{
    builder.AddJsonFile(path);
}).Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

Console.WriteLine(config.GetValue<string>("browser"));
Console.WriteLine(config.GetValue<string>("ipaddress"));
Console.WriteLine(config.GetValue<string>("domain"));


