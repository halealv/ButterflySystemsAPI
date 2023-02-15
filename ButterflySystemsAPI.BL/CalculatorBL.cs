using ButterflySystemsAPI.BL.Concrete;
using ButterflySystemsAPI.BL.Interfaces;
using ButterflySystemsAPI.Constants;

namespace ButterflySystemsAPI.BL
{
    public class CalculatorBL : ICalculator
    {
        public decimal GetResult(decimal num1, decimal num2, string operation)
        {
            var operationStrategy = Strategies.GetOperation(operation);
            var operationContext = new OperationContext(operationStrategy);

            return operationContext.GetResult(num1, num2);
        }

        public decimal GetResult(decimal num1, decimal num2, Operation operation)
        {
            var operationStrategy = Strategies.GetOperation(operation);
            var operationContext = new OperationContext(operationStrategy);

            return operationContext.GetResult(num1, num2);
        }
    }
}