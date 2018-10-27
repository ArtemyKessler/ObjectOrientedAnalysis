namespace PizzeriaV1
{
    public class Decorator<T>:Pizza where T : IIngridient, new()
    {
        public Decorator(Pizza pizza)
        {
            var addedIngrid = new T();
            Cost = pizza.Cost + addedIngrid.Cost();
            Description = pizza.Description + " + " + addedIngrid.GetDescription();
            Ingridients.AddRange(pizza.Ingridients);
            Ingridients.Add(typeof(T));
        }
    }
}