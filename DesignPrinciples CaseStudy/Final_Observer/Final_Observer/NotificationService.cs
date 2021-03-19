using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Observer
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> subscribers=new List<INotificationObserver>();
        

        public void AddSubscriber(INotificationObserver observer)
        {
            subscribers.Add(observer);
            Console.WriteLine("---------Admin added--------\n");
        }

        public void NotifySubscriber()
        {
            Console.WriteLine("---------Notification for Admin--------\n");
            foreach (var i in subscribers)
            {
                i.EmailNotification();
                i.WhatsAppNotification();
                i.SMSNotification();
            }

        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            subscribers.Remove(observer);
            Console.WriteLine("---------Admin Removed--------\n");
        }
    }
}
