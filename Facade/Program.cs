using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var scanFacade = new ScanFacade();

            scanFacade.Scan("http://github.com/somerepo");
        }
    }
}
