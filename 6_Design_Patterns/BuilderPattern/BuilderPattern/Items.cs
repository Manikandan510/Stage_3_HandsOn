using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Items
    {
        private List<string> packages = new List<string>();
        public void Add(string item) 
        {
            packages.Add(item);
        }
        public void Display() 
        {
            if (packages.Count == 3)
            {
                Console.WriteLine("\nChild package");
            }
            else 
            {
                Console.WriteLine("\nAdult package");
            }
            foreach (string i in packages) 
            {
                Console.Write(i+"\n");
            }
            Console.WriteLine();
        }
    }
}
