using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pdfGenerator = new PdfGenerator();

            Console.WriteLine("** PDF **");
            pdfGenerator.GenerateReport();

            Console.WriteLine("** CSV **");
            var csvGenerator = new CsvGenerator();

            csvGenerator.GenerateReport();
        }
    }
}
