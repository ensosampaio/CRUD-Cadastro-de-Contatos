using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel buscarPorLorgin(String login);
        
        UsuarioModel ListarPorId(int id);
        
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);

        bool Apagar(int id);

        UsuarioModel Atualizar(UsuarioModel usuario);

        
    }
}
