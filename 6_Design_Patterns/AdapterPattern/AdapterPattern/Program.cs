using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BugattiVeyron car = new BugattiVeyron();
            MovableAdapterImpl adapter = new MovableAdapterImpl(car);
            PriceAdapterImpl adap = new PriceAdapterImpl(car);
            
            Console.WriteLine("Before Conversion & implementing adapter");
            Console.WriteLine("Speed in Miles "+car.GetSpeed());
            Console.WriteLine("Price in USD "+car.GetPrice());
            Console.WriteLine("\nAfter Conversion & implementing adapter");
            Console.WriteLine("Speed in KPH " + adapter.GetSpeed());
            Console.WriteLine("Price in EURO " + adap.GetPrice());
        }
    }
}
