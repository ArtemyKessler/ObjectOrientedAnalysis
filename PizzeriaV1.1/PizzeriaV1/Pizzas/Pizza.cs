using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace PizzeriaV1
{
    public abstract class Pizza
    {
        
        public List<Type> Ingridients;
        public string State
        {
            set { _state = value;
                Console.WriteLine(_state);
            }
        }
        private string _state;

        public abstract double GetCost();
        public abstract string GetDescription();

        public Pizza()
        {
            Ingridients = new List<Type>();
            Ingridients.Add(typeof(CakeLayer));
        }

        public void Prepare()
        {
            State = "Приготовлена";
        }
        
        public void Cut()
        {
            State = "Порезана";
        }
        
        public void Box()
        {
            State = "Упакована";
        }
        
        public void Send()
        {
            State = "Отправлена";
        }

    }
}