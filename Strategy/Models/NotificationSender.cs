using Strategy.Strategies;

namespace Strategy.Models
{
    // The Context defines the interface of interest to clients.
    public class NotificationSender
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private INotificationSender _notificationSender;

        public NotificationSender()
        {

        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public NotificationSender(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetNotificationSender(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void SendNotification(string message)
        {
            //Some Code
            _notificationSender.SendNotification(message);
        }
    }
}
