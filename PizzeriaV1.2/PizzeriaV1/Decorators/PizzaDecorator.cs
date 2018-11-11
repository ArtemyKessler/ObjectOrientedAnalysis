
using System;
using System.Collections.Generic;

namespace PizzeriaV1
{
    public class PizzaDecorator: Pizza
    {
        private readonly double _addedCost;
        private readonly string _addedDescription;
        private readonly Pizza _pizza;
        private readonly IIngridient _ingridient;
        double discount = 1.0;
        
        public PizzaDecorator(Pizza pizza, params IIngridient[] addedIngrids)
        {
            _pizza = pizza;
            Ingridients = _pizza.Ingridients.GetRange(0,_pizza.Ingridients.Count);
            foreach (var ingrid in addedIngrids)
            {
                _ingridient = ingrid;
                if (_ingridient.GetType() == typeof(CakeLayer))
                {
                    throw new  ArgumentException("Нельзя добавить второй корж");
                }
                Ingridients.Add(_ingridient.GetType());
                if (Ingridients.Count % 7 == 0)
                {
                    discount *= 0.9;
                }

                _addedCost += _ingridient.GetCost();
                _addedDescription += $" {_ingridient.GetDescription()} + ";
            }
        }

        public override double GetCost()
        {
            double newCost;
            newCost = _pizza.GetCost();
            newCost += _addedCost;
            newCost *= discount; 
            return newCost;
        }

        public override string GetDescription()
        {
            string newDescription;
            newDescription = _pizza.GetDescription() + " + " + _addedDescription;
            newDescription += $"Благодаря скидке вы заплатите {discount} от первоначальной цены";

            return newDescription;
        }
    }
}