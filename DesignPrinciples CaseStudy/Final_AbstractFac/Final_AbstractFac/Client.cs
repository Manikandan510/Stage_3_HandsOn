using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AbstractFac
{
    public class Client
    {
        Factory factory;
        public Client(Factory fact)
        {
            this.factory = fact;
        }
        public void MakeFuniture(Channel ch) 
        {
            factory.makeOrder(ch,Product.Furniture);
        }
        public void MakeToys(Channel ch)
        {
            factory.makeOrder(ch, Product.Toys);
        }
        public void MakeElectronics(Channel ch)
        {
            factory.makeOrder(ch, Product.Electronic_Products);
        }
    }
}
