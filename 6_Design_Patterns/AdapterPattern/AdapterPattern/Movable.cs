using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface Movable // returns speed in MPH and price in Usd
    {
        double GetSpeed();
    }
    public interface Price 
    {
        double GetPrice();
    }
}