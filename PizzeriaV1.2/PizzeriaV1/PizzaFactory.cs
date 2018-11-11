using System;
using System.Collections; 
using System.Collections.Generic;

namespace PizzeriaV1
{
    public class PizzaFactory
    {
        public Pizza CreatePizza<T>(params IIngridient[] addedIngrids) where T: Pizza, new()
        {
            return new PizzaDecorator(new T(),addedIngrids);
        }
    }
}