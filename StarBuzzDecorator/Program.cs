using System;
using StarBuzzDecorator.AddComponents;
using StarBuzzDecorator.MainComponents;

namespace StarBuzzDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш заказ :");
            //Без дополнений
            Beverage beverage_instance1 = new Espresso();
            Console.WriteLine(beverage_instance1.GetDescription() + " " + beverage_instance1.cost() + "Р");

            //С дополнениями
            Beverage beverage_instance4 = new Espresso();
            
            beverage_instance4 = new Milk(beverage_instance4);
            beverage_instance4 = new Sugar(beverage_instance4);
            Console.WriteLine(beverage_instance4.GetDescription() + " " + beverage_instance4.cost() + "Р");


        }
    }
}
