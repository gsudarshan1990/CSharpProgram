// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder = new ConfigurationBuilder();
string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "appsettings.json";

builder.AddJsonFile(path);
IConfigurationRoot configurationRoot = builder.Build();
string browser = configurationRoot.GetValue<string>("BrowserType");
Console.WriteLine(browser);
Console.WriteLine(configurationRoot.GetValue<string>("Language"));
Console.WriteLine(configurationRoot.GetValue<string>("version"));

