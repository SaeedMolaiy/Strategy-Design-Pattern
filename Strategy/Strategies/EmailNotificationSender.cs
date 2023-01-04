using System;

namespace Strategy.Strategies
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class EmailNotificationSender : INotificationSender  
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email Strategy : {message}");
        }
    }
}
