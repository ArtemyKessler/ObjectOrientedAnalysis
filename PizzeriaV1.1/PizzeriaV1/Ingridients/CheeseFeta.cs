namespace PizzeriaV1
{
    public class CheeseFeta : IIngridient
    {
        public double GetCost()
        {
            return 4.5; 
        }

        public string GetDescription()
        {
            return "Сыр фета";
        }
    }
}