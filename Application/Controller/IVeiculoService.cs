using Domain.Commands;

namespace Application.Controller
{
    internal interface IVeiculoService
    {
        void PostAsync(VeiculoCommands command);
    }
}