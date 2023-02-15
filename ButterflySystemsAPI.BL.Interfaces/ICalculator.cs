using ButterflySystemsAPI.Constants;

namespace ButterflySystemsAPI.BL.Interfaces
{
    public interface ICalculator
    {
        decimal GetResult(decimal num1, decimal num2, string operation);
        decimal GetResult(decimal num1, decimal num2, Operation operation);
    }
}