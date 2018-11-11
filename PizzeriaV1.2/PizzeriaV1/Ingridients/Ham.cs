namespace PizzeriaV1
{
    public class Ham : IIngridient
    {
        public double GetCost()
        {
            return 4.7; 
        }

        public string GetDescription()
        {
            return "Ветчина";
        }
    }
}