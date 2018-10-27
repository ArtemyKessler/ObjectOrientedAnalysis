namespace PizzeriaV1
{
    public class CheeseParmezan : IIngridient
    {
        public double GetCost()
        {
            return 5.5; 
        }

        public string GetDescription()
        {
            return "Сыр пармезан";
        }
    }
}