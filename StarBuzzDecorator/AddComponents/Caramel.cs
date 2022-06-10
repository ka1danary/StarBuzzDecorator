using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.AddComponents
{
    public class Caramel : CondimentDecorator
    {
        Beverage beverage_instance;

        public Caramel(Beverage beverage_instance)
        {
            this.beverage_instance = beverage_instance;
        }

        public override string GetDescription()
        {
            return beverage_instance.GetDescription() + ", Caramel";
        }
        public override double cost()
        {
            return 20.0 + beverage_instance.cost();
        }

    }
}
