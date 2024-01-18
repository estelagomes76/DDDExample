using Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IVeiculoService _ClienteService;
        {
            _ClienteService = ClienteService;
        }
    }
}
