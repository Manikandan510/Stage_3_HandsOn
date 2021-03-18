using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable luxuryCar;
        public MovableAdapterImpl(Movable luxuryCarName) 
        {
            luxuryCar = luxuryCarName;
        }
        public double GetSpeed()
        {
            return ConvertMPHtoKPH(luxuryCar.GetSpeed());
        }
        private double ConvertMPHtoKPH(double mph)
        {
            return mph * 1.60934;
        }

        
    }
    public class PriceAdapterImpl : PriceAdapter 
    {
        private Price luxuryCar;
        public PriceAdapterImpl(Price luxuryCarName)
        {
            luxuryCar = luxuryCarName;
        }
        public double GetPrice()
        {
            return ConvertUSDtoEURO(luxuryCar.GetPrice());
        }
        private double ConvertUSDtoEURO(double usd)
        {
            return usd * 0.84;
        }
    }
}
