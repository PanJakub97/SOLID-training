// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello World!");

var cfg = Configuration.GetInstance();
var cfg2 = Configuration.GetInstance();

if (ReferenceEquals(cfg, cfg2))
{
    Console.WriteLine("Configuration is a singleton");
}
