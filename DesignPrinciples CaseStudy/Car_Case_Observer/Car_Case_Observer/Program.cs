using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Case_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var steve = new SteveObserver();
            var john = new JohnObserver();

            NotificationService service = new NotificationService();
            service.AddSubscriber(steve);
            service.AddSubscriber(john);

            service.NotifySubscriber();

            service.RemoveSubscriber(steve);

            Console.ReadKey();
        
        }
    }
}
