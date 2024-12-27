using CashFlow.Communication.Requests;
using CashFlow.Application.UseCases.Expenses.Register;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CashFlow.Communication.Responses;

namespace CashFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredExpenseJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestExpenseJson request)
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
