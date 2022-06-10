using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.MainComponents
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso";
        }

        public override double cost()
        {
            return 60.0;
        }
    }
    
}
