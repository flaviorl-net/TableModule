using System;
using System.Collections.Generic;
using System.Text;
using TableModule.Data.Model;

namespace TableModule.Business
{
    public interface IClienteBusiness
    {
        bool InserirCliente(string nome, string sobrenome, DateTime dataNascimento);

        List<Cliente> ObterClientes();

        void DeletarCliente(Guid id);

        void AtualizarCliente(Cliente cliente);
    }
}
