using System;

namespace PizzeriaV1
{
    public class PizzaFactory
    {
        public Pizza CreatePizza<T>() where T: Pizza, new()
        {
            return new T();
        }
    }
}