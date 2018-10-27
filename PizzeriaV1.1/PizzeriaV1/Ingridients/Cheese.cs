namespace PizzeriaV1
{
    public class Cheese : IIngridient
    {
        public double GetCost()
        {
            return 4; 
        }

        public string GetDescription()
        {
            return "Сыр обычный";
        }
    }
}