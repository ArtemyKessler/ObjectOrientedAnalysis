using System;
using System.Collections.Generic;
using System.Globalization;

namespace PizzeriaV1
{
    public abstract class Pizza
    {
        
        public List<Type> Ingridients;
        public string State;
        public double Cost;
        public string Description;

        public Pizza()
        {
            Ingridients = new List<Type>();
            Ingridients.Add(typeof(CakeLayer));
        }

        public void Prepare()
        {
            State = "Приготовлена";
            Console.WriteLine(State);
        }
        
        public void Cut()
        {
            State = "Порезана";
            Console.WriteLine(State);
        }
        
        public void Box()
        {
            State = "Упакована";
            Console.WriteLine(State);
        }
        
        public void Send()
        {
            State = "Отправлена";
            Console.WriteLine(State);
        }
        
    }
}