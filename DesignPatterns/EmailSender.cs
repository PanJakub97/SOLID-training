using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class EmailSender
    {
        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smtp server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        public void SendEmail(string adres, string title, string content)
        {
            ConnectToSmtpServer();
            InsertCredentials();

            Console.WriteLine($"Sending email to: {adres}, {title} {content}");

            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from the server");
        }
    }
}
