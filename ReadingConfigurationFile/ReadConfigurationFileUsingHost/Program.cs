// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.Extensions.Hosting;

string path = Directory.GetParent(@"../../..").FullName + Path.DirectorySeparatorChar + "config.json";

IHost host = Host.CreateApplicationBuilder().Build();