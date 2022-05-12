using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public static int TotalClientesCadastrados { get; set; } //Usando a palavra reservada static informamos que esta é uma propriedade referente a classe Cliente
        public Cliente()
        {
            TotalClientesCadastrados += 1;
        }


    }
}
