namespace PizzeriaV1
{
    public class OlivesGreen : IIngridient
    {
        public double Cost()
        {
            return 2.8; 
        }

        public string GetDescription()
        {
            return "Оливки";
        }
    }
}