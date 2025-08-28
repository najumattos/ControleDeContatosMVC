using CadastroDeContatosMVC.Models;
using System.Collections.Generic;

namespace CadastroDeContatosMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos(); //get
        ContatoModel Adicionar(ContatoModel contato);
    }
}
