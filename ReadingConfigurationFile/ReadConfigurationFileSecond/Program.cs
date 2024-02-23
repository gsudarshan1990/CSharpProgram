// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Configuration;


ConfigurationBuilder builder = new ConfigurationBuilder();

string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "config.json";
IConfigurationRoot config = builder.AddJsonFile(path).Build();
Console.WriteLine(config.GetValue<string>("name"));
Console.WriteLine(config.GetValue<string>("work"));
Console.WriteLine(config.GetValue<string>("organization"));