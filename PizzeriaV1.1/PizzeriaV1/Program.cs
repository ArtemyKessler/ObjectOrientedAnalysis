using System;
using System.Runtime.InteropServices;

namespace PizzeriaV1
{
    class Program
    {
        static void Main()
        {
            PizzaFactory myLittleFactory = new PizzaFactory();
            PizzaStore myPizzeria = new PizzaStore(myLittleFactory);
            
            Pizza order1 = myPizzeria.Order<Neapolitana>();
            order1 = new Decorator<Ham>(order1);
            order1 = new Decorator<Cheese>(order1);
            Console.WriteLine(order1.GetDescription() + " : " + order1.GetCost());
            Console.WriteLine(order1.Ingridients[0]);
            Console.WriteLine();
            
            Pizza order2 = myPizzeria.Order<FourCheese>();
            order2 = new Decorator<CheeseParmezan>(order2);
            order2 = new Decorator<Shrooms>(order2);
            Console.WriteLine(order2.GetDescription() + " : " + order2.GetCost());
            foreach (var type in order2.Ingridients)
            {
                Console.WriteLine();
                Console.Write(type);
            }
        }
    }
}