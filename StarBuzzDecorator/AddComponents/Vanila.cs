using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Vanila : CondimentDecorator
    {
        Beverage beverage_instance;

        public Vanila (Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.GetDescription() + ", Vanila";
        }
        public override double cost()
        {
            return 10.0 + beverage_instance.cost();
        }

    }
}
