using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> ListarTodosAsync();
        Task<Turma> ListarPorIdAsync(int id);
        Task AdicionarAsync(Turma turma);
        Task AlterarAsync(Turma turma);
        Task ExcluirAsync(int id);
    }
}
