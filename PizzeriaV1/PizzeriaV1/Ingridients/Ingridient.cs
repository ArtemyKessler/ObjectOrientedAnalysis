using System.Threading;

namespace PizzeriaV1
{
    public interface IIngridient
    {
        string GetDescription();
        double Cost();
    }
}