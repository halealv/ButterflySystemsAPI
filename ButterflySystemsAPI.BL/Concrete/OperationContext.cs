using ButterflySystemsAPI.BL.Interfaces;

namespace ButterflySystemsAPI.BL.Concrete
{
    public class OperationContext
    {
        private IOperation _operation;

        public OperationContext(IOperation operation)
        {
            _operation = operation;
        }

        public void SetStrategy(IOperation operation)
        {
            _operation = operation;
        }

        public decimal GetResult(decimal num1, decimal num2)
        {
            return _operation.GetResult(num1, num2);
        }
    }
}
