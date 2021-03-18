using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class BugattiVeyron : Movable,Price
    {
        public double GetPrice()
        {
            return 100;
        }

        public double GetSpeed()
        {
            return 268;
        }
    }
}
