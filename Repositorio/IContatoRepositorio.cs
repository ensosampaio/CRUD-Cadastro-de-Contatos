using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        bool Apagar(int id);

        ContatoModel Atualizar(ContatoModel contato);

        
    }
}
