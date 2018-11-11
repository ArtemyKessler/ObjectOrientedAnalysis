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
            
            Pizza order1 = myPizzeria.Order<Neapolitana>(new Tomatoes(),new Cheese(),new Shrooms());          
            
            Console.WriteLine(order1.GetDescription() + " : " + order1.GetCost());
            Console.WriteLine(order1.Ingridients[0]);
            Console.WriteLine();
            
            Pizza order2 = myPizzeria.Order<FourCheese>();
            Console.WriteLine(order2.GetDescription() + " : " + order2.GetCost());
            foreach (var type in order2.Ingridients)
            {
                Console.WriteLine();
                Console.Write(type);
            }
        }
    }
}