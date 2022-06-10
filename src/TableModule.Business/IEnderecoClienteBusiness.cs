using System;
using System.Collections.Generic;
using System.Text;
using TableModule.Data.Model;

namespace TableModule.Business
{
    public interface IEnderecoClienteBusiness
    {
        bool InserirEnderecoCliente(string logradouro, string endereco, int numero, string complemento, Guid clienteId);

        List<EnderecoCliente> ObterEnderecoCliente();

        void DeletarEnderecoCliente(Guid id);

        void AtualizarEnderecoCliente(EnderecoCliente enderecoCliente);
    }
}