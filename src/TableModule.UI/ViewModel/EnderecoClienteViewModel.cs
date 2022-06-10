using System;

namespace TableModule.UI.ViewModel
{
    public class EnderecoClienteViewModel
    {
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string NomeCliente { get; set; }
        public Guid ClienteId { get; set; }
    }
}
