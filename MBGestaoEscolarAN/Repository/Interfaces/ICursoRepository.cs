using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Curso>> ListarTodosAsync();
        Task<Curso> ListarPorIdAsync(int id);
        Task AdicionarAsync(Curso curso);
        Task AlterarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
