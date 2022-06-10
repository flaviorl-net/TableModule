using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TableModule.Data;
using TableModule.Data.Model;

namespace TableModule.Business
{
    public class EnderecoClienteBusiness : IEnderecoClienteBusiness
    {
        private readonly AppDbContext _context;

        public EnderecoClienteBusiness(AppDbContext context)
        {
            _context = context;
        }

        public bool InserirEnderecoCliente(Guid id, string logradouro, string endereco, int numero, string complemento)
        {
            if (string.IsNullOrWhiteSpace(logradouro))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco))
            {
                return false;
            }

            if (numero == 0)
            {
                return false;
            }

            var enderecoCliente = new EnderecoCliente()
            {
                Id = id,
                Endereco = endereco,
                Complemento = complemento,
                Logradouro = logradouro,
                Numero = numero
            };

            _context.EnderecoCliente.Add(enderecoCliente);
            _context.SaveChanges();

            return true;
        }

        public void AtualizarEnderecoCliente(EnderecoCliente enderecoCliente)
        {
            throw new NotImplementedException();
        }

        public void DeletarEnderecoCliente(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoCliente> ObterEnderecoCliente()
        {
            return _context.EnderecoCliente.ToList();
        }
    }
}
