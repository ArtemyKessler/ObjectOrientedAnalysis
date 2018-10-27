namespace PizzeriaV1
{
    public class CheeseButter : IIngridient
    {
        public double GetCost()
        {
            return 3.5; 
        }

        public string GetDescription()
        {
            return "Сыр сливочный";
        }
    }
}