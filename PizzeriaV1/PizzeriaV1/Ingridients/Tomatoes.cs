namespace PizzeriaV1
{
    public class Tomatoes : IIngridient
    {
        public double Cost()
        {
            return 3; 
        }

        public string GetDescription()
        {
            return "Помидоры";
        }
    }
}