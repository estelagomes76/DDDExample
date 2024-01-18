using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    internal class Cliente
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Habilitação { get; set; }
        public int DataNascimento { get; set; }
        public int Estado { get; set; }

    }
}
