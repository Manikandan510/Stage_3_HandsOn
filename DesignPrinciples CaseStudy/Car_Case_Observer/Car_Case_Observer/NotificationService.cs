using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Case_Observer
{
    class NotificationService : INotificationService
    {
        private List<INotificationObserver> observer = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            observer.Add(notificationObserver);
            Console.WriteLine("-----------------User Added----------");
            foreach (var ob in observer)
            {
                Console.WriteLine("\t" + ob.Name);
            }
        }
        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            observer.Remove(notificationObserver);
            Console.WriteLine("-----------------User Removed----------");
            Console.WriteLine();
            foreach (var ob in observer) 
            {
                Console.WriteLine("\t" + ob.Name);
            }
        }
        public void NotifySubscriber()
        {
            Console.WriteLine("-----------------Server down----------");
            foreach (var ob in observer) 
            {
                ob.OnServerDown();
            }
        }

    }
}
