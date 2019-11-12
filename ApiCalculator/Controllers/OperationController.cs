

using Microsoft.AspNetCore.Mvc;
using NetCoreCalculator.Models;

namespace ApiCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : Controller
    {
    
        [HttpGet ("{Suma}")]
        public IActionResult Suma( Operation model )
        {
            if ( model.OperationType == OperationType.Addition )
                model.Result = model.NumberA + model.NumberB;
            return View( model );
        }

        [HttpGet ("{Resta}")]
         public IActionResult Resta( Operation model )
        {
            if ( model.OperationType == OperationType.Resta )
                model.Result = model.NumberA - model.NumberB;
            return View( model );
        }

        [HttpGet ("{Multiplicacion}")]
         public IActionResult Multiplicacion( Operation model )
        {
            if ( model.OperationType == OperationType.Multiplication )
                model.Result = model.NumberA * model.NumberB;
            return View( model );
        }

        [HttpGet ("{Division}")]
         public IActionResult Division( Operation model )
        {
            if ( model.OperationType == OperationType.Division )
                model.Result = model.NumberA / model.NumberB;
            return View( model );
        }
    }
}