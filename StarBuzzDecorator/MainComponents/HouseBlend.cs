using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.MainComponents
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }
        public override double cost()
        {
            return 80.0;
        }
    }
}
