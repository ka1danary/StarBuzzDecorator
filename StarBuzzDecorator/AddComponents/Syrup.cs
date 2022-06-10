using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Syrup : CondimentDecorator
    {
        Beverage beverage_instance;

        public Syrup(Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.GetDescription() + ", Syrop";
        }
        public override double cost()
        {
            return 25.0 + beverage_instance.cost();
        }

        
    }
}
