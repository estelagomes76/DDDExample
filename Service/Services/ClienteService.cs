using Domain.Commands;
using Domain.Enums;
using Domain.Interface;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClienteService : IClienteService
    {
        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }
        private readonly IClienteRepository _repository;
    
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ClienteCommands command)
        {
            return await _repository.PostAsync(command);
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
