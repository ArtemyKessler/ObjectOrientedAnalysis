using System;

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
            Console.WriteLine(order1.Description + " : " + order1.Cost);
            Console.WriteLine(order1.Ingridients[0]);
            
            Pizza order2 = myPizzeria.Order<FourCheese>();
            order2 = new Decorator<CheeseParmezan>(order2);
            order2 = new Decorator<Shrooms>(order2);
            Console.WriteLine(order2.Description + " : " + order2.Cost);
            Console.WriteLine(order2.Ingridients[0]);
        }
    }
}