using ButterflySystemsAPI.BL.Interfaces;

namespace ButterflySystemsAPI.BL.Concrete
{
    public class Addition : IOperation
    {
        public decimal GetResult(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
