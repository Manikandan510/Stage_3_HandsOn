using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Observer
{
    public class AdminObserver : INotificationObserver
    {
        public string ProcessName { get => "Event"; }
        public void EmailNotification()
        {
            Console.WriteLine("-------Email Notification----Ticket Count Exceeded for {0}---------", ProcessName);
        }

        public void SMSNotification()
        {
            Console.WriteLine("-------SMS Notification----Ticket Count Exceeded for {0}---------",ProcessName);
        }

        public void WhatsAppNotification()
        {
            Console.WriteLine("-------WhatsApp Notification----Ticket Count Exceeded for {0}---------", ProcessName);
        }
    }
}
