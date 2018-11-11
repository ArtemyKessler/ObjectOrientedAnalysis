using System.Collections.Generic;
using System.Linq;
using System;

namespace PizzeriaV1
{
    public class Ester: Pizza
    {
        private static readonly List<Type> EsterIngridients = new List<Type>
        {
            typeof(Cheese), 
            typeof(Tomatoes),
            typeof(Ham),
            typeof(Shrooms)
        };
        public Ester()
        {
            Ingridients.AddRange(EsterIngridients);
        }
        
        public override double GetCost()
        {
            return 40;
        }
        
        public override string GetDescription()
        {
            return "Эстер";
        }
    }
}