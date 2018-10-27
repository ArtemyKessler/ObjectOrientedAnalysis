using System.Collections.Generic;
using System;
using System.Linq;

namespace PizzeriaV1
{
    public class FourCheese: Pizza
    {
        private static readonly List<Type> FourCheeseIngridients = new List<Type>
        {
           typeof(CheeseFormaggio),
           typeof(CheeseButter),
           typeof(CheeseParmezan),
           typeof(CheeseFeta)
        };
        public FourCheese()
        {
            Ingridients.AddRange(FourCheeseIngridients);
            Cost = 55;
            Description = "4 Сыра"; 
        }
    }
}