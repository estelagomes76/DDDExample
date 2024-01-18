using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IClienteRepository
    {
        //A interface é um contrato , apenas usamos para adicionar metodos, não é feita implementação de nada
        Task<string> PostAsync(ClienteCommands command);
    }
            

}
