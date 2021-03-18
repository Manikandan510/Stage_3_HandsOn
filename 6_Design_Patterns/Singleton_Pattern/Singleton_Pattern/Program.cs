using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn instance = DBConn.getInstance();
            DBConn instance1 = DBConn.getInstance();
            
            instance.display("First Instance");
            instance1.display("Second Instance");
            
            Console.ReadLine();
        }
    }
}
