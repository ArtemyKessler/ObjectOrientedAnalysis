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
        }

        public override double GetCost()
        {
            return 45;
        }

        public override string GetDescription()
        {
            return "Неаполитана";
        }
    }
}