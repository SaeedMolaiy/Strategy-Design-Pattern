using System;
using Strategy.Models;
using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main()
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var sender = new NotificationSender();

            INotificationSender emailSender = new EmailNotificationSender();
            sender.SetNotificationSender(emailSender);
            sender.SendNotification("Hi Strategy Design Pattern");

            Console.WriteLine();

            INotificationSender smsSender = new SmsNotificationSender();
            sender.SetNotificationSender(smsSender);
            sender.SendNotification("Hi Strategy Design Pattern");

            Console.ReadKey();
        }
    }
}
