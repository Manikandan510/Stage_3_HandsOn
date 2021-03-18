using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface MovableAdapter
    {
        double GetSpeed();
    }
    public interface PriceAdapter 
    {
        double GetPrice();
    }
}
