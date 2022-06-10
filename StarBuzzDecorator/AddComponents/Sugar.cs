using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Sugar : CondimentDecorator
    {
        Beverage beverage_instance;
        public Sugar(Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.GetDescription() + ", Sugar";
        }
        public override double cost()
        {
            return 5.0 + beverage_instance.cost();
        }

        
    }
}
