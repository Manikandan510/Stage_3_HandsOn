using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);
            carClient.BuildMicroCar(Location.USA);
            carClient.BuildMiniCar(Location.INDIA);
            carClient.BuildLuxuryCar(Location.DEFAULT);

            Console.ReadKey();
        }
        #region Car related - Product and its parent abstract class
        public enum CarType 
        {
            MICRO,MINI,LUXURY
        }
        public enum Location 
        {
            DEFAULT,USA,INDIA
        }
        public abstract class Car 
        {
            public Car(CarType model,Location location) 
            {
                this.CarType = model;
                this.Location = location;
            }
            public abstract void Construct();
            public CarType CarType { get; set; }
            public Location Location { get; set; }
            public override string ToString()
            {
                return "CarModel - " + CarType.ToString() + " located in " + Location.ToString();
            }
        }
        class LuxuryCar : Car 
        {
            public LuxuryCar(CarType carType, Location location) : base(CarType.LUXURY, location) 
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to luxury car");
                Console.WriteLine(base.ToString());
            }
        }
        class MicroCar:Car
        {
            public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to Micro car");
                Console.WriteLine(base.ToString());
            }
        }
        class MiniCar : Car
        {
            public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Connecting to Mini car");
                Console.WriteLine(base.ToString());
            }
        }
        #endregion
        #region Abstract Factory to expose to client
        //abstract factory 
        public interface CarFactory 
        {
            void makeCar(Location location, CarType carType);
        }
        public class ConcreteCarFactory : CarFactory
        {
            private Car car;

            public void makeCar(Location location, CarType carType)
            {
                if (carType == CarType.LUXURY)
                {
                    car = new LuxuryCar(carType, location);
                }
                else if (carType == CarType.MICRO)
                {
                    car = new MicroCar(carType, location);
                }
                else 
                {
                    car = new MiniCar(carType, location);
                }
            }
        }
        public class CarClient 
        {
            CarFactory CF;
            public CarClient(CarFactory carFactory) 
            {
                CF = carFactory;
            }
            public void BuildMicroCar(Location location) 
            {
                CF.makeCar(location,CarType.MICRO);
            }
            public void BuildLuxuryCar(Location location)
            {
                CF.makeCar(location, CarType.LUXURY);
            }
            public void BuildMiniCar(Location location)
            {
                CF.makeCar(location, CarType.MINI);
            }
        }
        #endregion
    }
}
