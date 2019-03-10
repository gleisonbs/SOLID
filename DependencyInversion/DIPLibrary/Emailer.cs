using System;
using System.Net;
using System.Net.Mail;

namespace DIPLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}