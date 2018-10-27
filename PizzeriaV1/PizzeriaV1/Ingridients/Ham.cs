namespace PizzeriaV1
{
    public class Ham : IIngridient
    {
        public double Cost()
        {
            return 4.7; 
        }

        public string GetDescription()
        {
            return "Ветчина";
        }
    }
}