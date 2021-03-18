using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Case_Observer
{
    class SteveObserver : INotificationObserver
    {
        public string Name { get => "Steve"; }

        public void OnServerDown()
        {
            Console.WriteLine(Name + " Server Down ");
        }
    }
}
