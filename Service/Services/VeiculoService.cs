using Domain.Commands;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommands command)
        {
            //Todo 
            // Incluir validação, só podem cadastrar veículos com até 5 anos de uso
            // to do
            // Incluir Somente carros do tipo SUV, Sedan e Hatch
            if(command.TipoVeiculo !=.ETipoVeiculo.SUV
                || command)
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
