namespace PizzeriaV1
{
    public class CheeseParmezan : IIngridient
    {
        public double Cost()
        {
            return 5.5; 
        }

        public string GetDescription()
        {
            return "Сыр пармезан";
        }
    }
}