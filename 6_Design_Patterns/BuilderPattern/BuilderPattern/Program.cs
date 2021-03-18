using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            Builder b1 = new ConcreteAdult();
            Builder b2 = new ConcreteChild();

            dir.Construct(b1);
            Items I1 = b1.GetItems();
            I1.Display();

            dir.Construct(b2);
            Items I2 = b2.GetItems();
            I2.Display();

            Console.ReadLine();

        }
    }
}
