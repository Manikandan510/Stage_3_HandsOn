using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace AsyncAwait
{
    class Program
    {
        public async static Task FirstMethod() 
        {
            string FirstMethods = await SecondMethod();
            Console.WriteLine(FirstMethods);
            Console.ReadLine();
        }
        public async static Task<string> SecondMethod()
        {
            Thread.Sleep(5000);
            return "String from Second Method";
        }
        static void Main(string[] args)
        {
            FirstMethod();
        }
    }
}
