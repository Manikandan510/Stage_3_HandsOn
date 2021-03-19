using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AbstractFac
{
    public abstract class Order 
    {
        public Channel channel { get; set; }
        public Product product { get; set; }
        public Order(Product productType,Channel channel) 
        {
            this.product = productType;
            this.channel = channel;
        }
        public abstract void processOrder();
    }
    public class ElectronicOrder : Order
    {
        public ElectronicOrder(Channel channel) : base(Product.Electronic_Products, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed through " + channel.ToString());
        }
    }
    public class ToysOrder : Order
    {
        public ToysOrder(Channel channel) : base(Product.Toys, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed through " + channel.ToString());
        }
    }
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Channel channel) : base(Product.Furniture, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(product.ToString() + " order is placed through " + channel.ToString());
        }
    }
}
