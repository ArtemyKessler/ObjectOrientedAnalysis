
using System;
using System.Collections.Generic;

namespace PizzeriaV1
{
    public class Decorator<T>:Pizza where T : IIngridient, new()
    {
        private readonly Pizza _pizza;
        private readonly IIngridient _ingridient;
        
        public Decorator(Pizza pizza)
        {
            _pizza = pizza;
            _ingridient = new T();
            Ingridients = _pizza.Ingridients.GetRange(0,_pizza.Ingridients.Count);
            Ingridients.Add(typeof(T));
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + _ingridient.GetCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + " + " + _ingridient.GetDescription();
        }
    }
}