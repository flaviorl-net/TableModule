using System;
using System.Collections.Generic;
using System.Text;

namespace TableModule.Data.Model
{
    public class EnderecoCliente
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public Guid ClienteId { get; set; }
    }
}