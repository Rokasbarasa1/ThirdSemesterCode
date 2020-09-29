using System;
using System.Collections.Generic;
using System.Text;

namespace GasPump
{
    public class Pump
    {
        public double maxCapacity { get; set; }
        public double capacityLiters { get; set; }
        public double priceLiter { get; set; }

        public Pump()
        {
            capacityLiters = 1100;
            priceLiter = 9.82;
        }
        public double CostOfFullTank(double tank)
        {
            return tank * priceLiter;
        }

        public double FillTank(double litersToFill)
        {
            capacityLiters = capacityLiters - litersToFill;
            return litersToFill * priceLiter;
        }

        public DateTime FillPump()
        {
            if(maxCapacity > capacityLiters)
            {
                capacityLiters = maxCapacity;
            }
            return DateTime.Now;
        }
    }
}
