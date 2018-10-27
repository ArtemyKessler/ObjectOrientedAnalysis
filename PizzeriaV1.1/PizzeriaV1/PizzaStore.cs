using System;

namespace PizzeriaV1
{
    public class PizzaStore
    {
        public PizzaFactory Factory;

        public PizzaStore(PizzaFactory factory)
        {
            Factory = factory;
        }


        public Pizza Order<T>() where T : Pizza, new()
        {
            Pizza pizza;
            pizza = Factory.CreatePizza<T>();
            pizza.Prepare();
            pizza.Cut();
            pizza.Box();
            pizza.Send();
            return pizza;
        }

    }
}