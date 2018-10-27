using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaV1
{
    public class Neapolitana: Pizza
    {
        private static readonly List<Type> NeapolitanaIngridients = new List<Type>
        {
            typeof(Cheese),
            typeof(Shrooms),
            typeof(OlivesBlack),
            typeof(OlivesGreen),
            typeof(Ham)
        };
        public Neapolitana()
        {
            Ingridients.AddRange(NeapolitanaIngridients);
            Cost = 45;
            Description = "Неаполитана"; 
        }
    }
}