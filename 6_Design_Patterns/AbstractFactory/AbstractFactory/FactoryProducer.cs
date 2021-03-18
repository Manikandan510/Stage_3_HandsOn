using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static Factory getFactory(bool val) 
        {
            if (val)
            {
                return new MercedesFactory();
            }
            else 
            {
                return new AudiFactory();
            }
        }
    }
}
