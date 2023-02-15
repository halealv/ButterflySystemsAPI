using ButterflySystemsAPI.BL.Interfaces;
using ButterflySystemsAPI.Constants;
using Microsoft.AspNetCore.Mvc;

namespace ButterflySystemsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("Addition/{num1}/{num2}")]
        public decimal Addition(decimal num1, decimal num2)
        {
            return _calculator.GetResult(num1, num2, "+");
        }

        [HttpPost("Subtraction/{num1}/{num2}")]
        public decimal Subtraction(decimal num1, decimal num2)
        {
            return _calculator.GetResult(num1, num2, "-");
        }

        [HttpPost("Multiplication/{num1}/{num2}")]
        public decimal Multiplication(decimal num1, decimal num2)
        {
            return _calculator.GetResult(num1, num2, "*");
        }

        [HttpPost("Division/{num1}/{num2}")]
        public decimal Division(decimal num1, decimal num2)
        {
            return _calculator.GetResult(num1, num2, "/");
        }

        [HttpPost("GetResult/{num1}/{num2}/{operation}")]
        public decimal GetResult(decimal num1, decimal num2, string operation)
        {
            operation = System.Net.WebUtility.UrlDecode(operation);

            return _calculator.GetResult(num1, num2, operation);
        }

        [HttpPost("GetResultEnum/{num1}/{num2}/{operation}")]
        public decimal GetResultEnum(decimal num1, decimal num2, Operation operation)
        {
            return _calculator.GetResult(num1, num2, operation);
        }
    }
}
