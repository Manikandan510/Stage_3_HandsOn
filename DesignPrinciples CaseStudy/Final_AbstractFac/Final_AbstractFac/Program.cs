using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AbstractFac
{
    public enum Product 
    {
        Electronic_Products,Toys,Furniture
    }
    public enum Channel 
    {
        ECommerceWebsite,TeleCallerAgents
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory fact = new ConcreteFactory();
            Client client = new Client(fact);
            client.MakeElectronics(Channel.ECommerceWebsite);
            Console.WriteLine("---------------");
            client.MakeFuniture(Channel.TeleCallerAgents);
            Console.WriteLine("---------------");
            client.MakeToys(Channel.ECommerceWebsite);
            Console.WriteLine("---------------");
            Console.ReadKey();
        }
    }
}
