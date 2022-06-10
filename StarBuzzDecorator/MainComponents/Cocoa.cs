using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzDecorator.MainComponents
{
    public class Cocoa : Beverage
    {
        public Cocoa()
        {
            description = "Cocoa";
        }
        public override double cost()
        {
            return 100.0;
        }
    }
}
