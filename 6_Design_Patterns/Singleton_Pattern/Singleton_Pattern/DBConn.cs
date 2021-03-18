using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public sealed class DBConn
    {
        private static DBConn instance;
        private DBConn() 
        {
            Console.WriteLine("Single Instance created");
        }
        public static DBConn getInstance() 
        {
            if (instance==null) 
            {
                instance = new DBConn();
            }
            return instance;
        }
        public void display(string i) 
        {
            Console.WriteLine(i);
        }
    }
}
