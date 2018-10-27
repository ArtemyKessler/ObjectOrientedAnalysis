namespace PizzeriaV1
{
    public class CheeseFormaggio : IIngridient
    {
        public double Cost()
        {
            return 5; 
        }

        public string GetDescription()
        {
            return "Сыр формаджио";
        }
    }
}