using CadastroDeContatosMVC.Models;

namespace CadastroDeContatosMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
