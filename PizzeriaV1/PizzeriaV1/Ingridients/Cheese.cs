namespace PizzeriaV1
{
    public class Cheese : IIngridient
    {
        public double Cost()
        {
            return 4; 
        }

        public string GetDescription()
        {
            return "Сыр обычный";
        }
    }
}