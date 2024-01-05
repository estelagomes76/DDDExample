﻿using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IVeiculoService
    {
        //A interface é um contrato , apenas usamos para adicionar metodos, não é feita implementação de nada

        Task PostAsync(VeiculoCommands command);
        void PostAsync();
        void GetAsync();

    }
}