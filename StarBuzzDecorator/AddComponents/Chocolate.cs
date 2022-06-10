using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Chocolate : CondimentDecorator
    {
        Beverage beverage_instance;

        public Chocolate (Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.GetDescription() + ", Chocolate";
        }
        public override double cost()
        {
            return 30.0 + beverage_instance.cost();
        }

    }
}
