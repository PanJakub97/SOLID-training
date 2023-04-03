using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pizzaBase = new MediumPizza();

            var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

            Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()}");

            var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);
            Console.WriteLine($"mediumPizzaWithCheese and salami : {p2.CalculatePrice()}");

            var doubleSalamiCheesePizza = new SalamiPizzaDecorator(p2);

            Console.WriteLine($"doubleSalamiCheesePizza: {doubleSalamiCheesePizza.CalculatePrice()}");
        }
    }
}
