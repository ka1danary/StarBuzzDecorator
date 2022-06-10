using System;
using System.Collections.Generic;
using System.Text;


namespace StarBuzzDecorator
{
    public abstract class Beverage
    {
        public string description; 
        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
     
    }
}
