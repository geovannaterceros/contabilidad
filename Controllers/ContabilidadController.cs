using Microsoft.AspNetCore.Mvc;
using System.Linq;
using prueba.BL;
using prueba.Model;

namespace prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContabilidadController : Controller
    {
        IComprobanteBL _comprobanteBL;
        public ContabilidadController(IComprobanteBL comprobanteBL)
        {
            _comprobanteBL = comprobanteBL;
        }

        [HttpGet("comprobante")]
        public IActionResult GetComprobante()
        {
            ResultOutput resultOutput = new ResultOutput();

            var respuesta = _comprobanteBL.BuscarComprobante();

            if (respuesta.Count() > 0) 
            {
                resultOutput.Comprobantes = respuesta;
                resultOutput.EsError = false;
                resultOutput.Mensaje = "Correctamente";
                resultOutput.CodigoError = "Sin Error";
            }
            return Ok(resultOutput);
        }

        [HttpPost("saveComprobante")]
        public IActionResult SaveComprobante([FromBody] Comprobante comprobante)
        {
        
           _comprobanteBL.CreateComprobante(comprobante);
                      
            return Ok(_comprobanteBL.BuscarID());
        }
    }
}
