namespace PizzeriaV1
{
    public class Shrooms : IIngridient
    {
        public double Cost()
        {
            return 3.5; 
        }

        public string GetDescription()
        {
            return "Грибы";
        }
    }
}