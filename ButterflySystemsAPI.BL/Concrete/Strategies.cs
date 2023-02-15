using ButterflySystemsAPI.BL.Interfaces;
using ButterflySystemsAPI.Constants;

namespace ButterflySystemsAPI.BL.Concrete
{
    public class Strategies
    {
        private static readonly Dictionary<string, IOperation> strategies = new()
        {
            {"+", new Addition() },
            {"-", new Subtraction() },
            {"*", new Multiplication() },
            {"/", new Division() },
        };

        private static readonly Dictionary<Operation, IOperation> strategiesEnum = new()
        {
            {Operation.Addition, new Addition() },
            {Operation.Subtraction, new Subtraction() },
            {Operation.Multiplication, new Multiplication() },
            {Operation.Division, new Division() },
        };

        public static IOperation GetOperation(string operation)
        {
            return strategies[operation];
        }

        public static IOperation GetOperation(Operation operation)
        {
            return strategiesEnum[operation];
        }
    }
}