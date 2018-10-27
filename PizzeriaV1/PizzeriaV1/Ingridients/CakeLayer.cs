namespace PizzeriaV1
{
    public class CakeLayer: IIngridient
    {
        public double Cost()
        {
            return 0;
        }

        public string GetDescription()
        {
            return "Коржик"; 
        }
    }
}