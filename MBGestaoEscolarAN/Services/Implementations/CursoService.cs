using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CursoService :ICursoService
    {
        private readonly SQLServerDbContext _contexto;
        public CursoService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public Task<int> AdicionarAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AlterarAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Curso> ListarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Curso>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
