namespace PizzeriaV1
{
    public class Tomatoes : IIngridient
    {
        public double GetCost()
        {
            return 3; 
        }

        public string GetDescription()
        {
            return "Помидоры";
        }
    }
}