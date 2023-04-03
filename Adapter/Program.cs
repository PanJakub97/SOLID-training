using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            INotificationSender notificationSender = new SmsSenderAdapter();
            notificationSender.SendNotification(1, new Notification() { Title = "Test", Body = "Body" });
        }
    }
}
