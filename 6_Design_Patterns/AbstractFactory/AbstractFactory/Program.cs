using System;
using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Audi 
            Factory factory=FactoryProducer.getFactory(true);   //false for Audi
            ITire TireOfCar = factory.makeTire();
            IHeadlight HeadlightOfCar = factory.makeHeadlight();
            TireOfCar.tire();
            HeadlightOfCar.headlight();
            
            //Mercedes
            factory = FactoryProducer.getFactory(true);        //true for Mercedes
            TireOfCar = factory.makeTire();
            HeadlightOfCar = factory.makeHeadlight();
            TireOfCar.tire();
            HeadlightOfCar.headlight();

            Console.ReadLine();
        }
    }
}
