using Domain.Commands;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        
        private string stringconnection = @"Server=(localdb)\\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommands command)
        {
            string queryInsert = @"INSERT INTO Cliente(Id, Nome, Habilitacao, DataNascimento, Estado)
                                 Values(@Id, @Nome, @habilitacao, @DataNascimento, @Estado)";

            using (SqlConnection conn = new SqlConnection(stringconnection))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = (int)command.Montadora,

                });
                return "Veiculo cadastrado com sucesso";

            }
        }
}
