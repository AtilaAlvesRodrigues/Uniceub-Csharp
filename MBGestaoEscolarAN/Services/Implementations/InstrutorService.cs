using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService : IInstrutorService
    {
        private readonly SQLServerDbContext _contexto;
        public InstrutorService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }
    }       
}
