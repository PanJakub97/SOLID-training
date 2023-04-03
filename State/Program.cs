using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.EjectCard();

            context.InsertCard();

            context.InsertPin(1111);

            context.InsertCard();

            context.InsertPin(8888);

            context.WithdrawCash(2000);

            context.InsertCard();
        }
    }
}
