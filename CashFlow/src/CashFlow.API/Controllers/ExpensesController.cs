﻿using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {

        [HttpPost]
        public IActionResult Register([FromBody] RequestExpenseJson request)
        {
            return Created();
        }
    }
}
