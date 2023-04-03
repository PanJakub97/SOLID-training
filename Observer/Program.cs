using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("subscriber1");
            var subscriber2 = new Subscriber("subscriber2");

            var publisher = new Publisher();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify("test message");

            publisher.Unsubscribe(subscriber1);

            publisher.Notify("test message2");
        }
    }
}
