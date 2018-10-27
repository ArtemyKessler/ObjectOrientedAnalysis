using System;

namespace PizzeriaV1
{
    public class PizzaStore
    {
        public PizzaFactory factory;

        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }


        public Pizza Order<T>() where T : Pizza, new()
        {
            Pizza pizza;
            pizza = factory.CreatePizza<T>();
            pizza.Prepare();
            pizza.Cut();
            pizza.Box();
            pizza.Send();
            return pizza;
        }

    }
}