using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage_instance;
        public Milk(Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.description + ", Milk";
        }
        public override double cost()
        {
            return 20.0 + beverage_instance.cost();
        }

    }
}
