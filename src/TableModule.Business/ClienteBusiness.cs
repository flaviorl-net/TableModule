using System;
using System.Collections.Generic;
using System.Linq;
using TableModule.Data;
using TableModule.Data.Model;

namespace TableModule.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly AppDbContext _context;

        public ClienteBusiness(AppDbContext context)
        {
            _context = context;
        }

        public bool InserirCliente(string nome, string sobrenome, DateTime dataNascimento)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(sobrenome))
            {
                return false;
            }

            if (dataNascimento.Year < 1900)
            {
                return false;
            }

            var cliente = new Cliente()
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                SobreNome = sobrenome,
                DataNascimento = dataNascimento
            };

            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return true;
        }

        public List<Cliente> ObterClientes()
        {
            return _context.Cliente.ToList();
        }

        public void DeletarCliente(Guid id)
        {

        }

        public void AtualizarCliente(Cliente cliente)
        {

        }
    }
}
