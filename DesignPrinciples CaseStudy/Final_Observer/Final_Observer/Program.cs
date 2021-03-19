using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver admin = new AdminObserver();
            NotificationService notificationService = new NotificationService();

            notificationService.AddSubscriber(admin);
            Console.WriteLine("Welcome to the Cultural Events,Lets Proceed to TicketBooking\n");
            while (true)
            {
                Console.WriteLine("Enter the number of tickets");
                int i = Convert.ToInt32(Console.ReadLine());

                if (i > 100)
                {
                    notificationService.NotifySubscriber();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Tickets Booked");
                    break;
                }
                Console.WriteLine();
            }
            notificationService.RemoveSubscriber(admin);
            Console.ReadLine();
        }
    }
}
