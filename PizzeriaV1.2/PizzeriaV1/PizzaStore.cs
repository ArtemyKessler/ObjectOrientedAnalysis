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

        public Pizza Order<T>(params IIngridient[] addedIngrids) where T : Pizza, new()
        {
            Pizza pizza;
            pizza = Factory.CreatePizza<T>(addedIngrids);
            pizza.Prepare();
            pizza.Cut();
            pizza.Box();
            pizza.Send();
            return pizza;
        }
        
        
    }
}