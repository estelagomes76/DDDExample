using Domain.Commands;
using Domain.Enums;
using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
             _veiculoService = veiculoService;
        }

        [HttpPost]
        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommands command)
        {
            
            return Ok(await _veiculoService.PostAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]

        public Task<IActionResult GetAsync(int DiasSimulacaoAluguel, ETipoVeiculo tipoVeiculo)

        {
            return Ok(_veiculoService.SimularVeiculoAluguel(DiasSimulacaoAluguel, tipoVeiculo);
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult Alugar()
        {
            return Ok();
        }   
        
    }
}
