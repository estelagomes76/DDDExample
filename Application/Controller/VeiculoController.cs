using Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService await_veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            await_veiculoService = veiculoService;
        }

        [HttpPost]
        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommands command)
        {
            await_veiculoService.PostAsync(command)
            return Ok();
        }
        [HttpGet]
        [Route("SimularAluguel")]

        public IActionResult GetAsync()

        {
            return Ok();
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult Alugar()
        {
            return Ok();
        }   
        
    }
}
