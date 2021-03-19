using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Observer
{
    public interface INotificationObserver
    {
        string ProcessName { get; }
        void EmailNotification();
        void WhatsAppNotification();
        void SMSNotification();
    }
}
