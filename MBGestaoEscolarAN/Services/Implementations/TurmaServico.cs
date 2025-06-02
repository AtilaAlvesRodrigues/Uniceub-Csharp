using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaServico : ITurmaServico
    {
        private readonly SQLServerDbContext _contexto;
        public TurmaServico(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }
        // Implementação de métodos específicos para a TurmaServico pode ser adicionada aqui
    }   
}
