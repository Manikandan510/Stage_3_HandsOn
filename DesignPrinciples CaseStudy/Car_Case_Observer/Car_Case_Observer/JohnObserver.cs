using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Case_Observer
{
    class JohnObserver : INotificationObserver
    {
        public string Name { get => "John"; }

        public void OnServerDown()
        {
            Console.WriteLine(Name + " Server Down ");
        }
    }
}
