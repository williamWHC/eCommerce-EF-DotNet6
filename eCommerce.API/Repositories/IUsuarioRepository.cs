using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario Get(int id);
        void Creat(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
