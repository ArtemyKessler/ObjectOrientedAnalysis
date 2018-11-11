namespace PizzeriaV1
{
    public class CakeLayer: IIngridient
    {
        public double GetCost()
        {
            return 0;
        }

        public string GetDescription()
        {
            return "Коржик"; 
        }
    }
}