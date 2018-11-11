namespace PizzeriaV1
{
    public class OlivesBlack : IIngridient
    {
        public double GetCost()
        {
            return 2.5; 
        }

        public string GetDescription()
        {
            return "Маслины";
        }
    }
}