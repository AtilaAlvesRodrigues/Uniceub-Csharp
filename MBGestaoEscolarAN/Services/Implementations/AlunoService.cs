using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class AlunoService:IAlunoService
    {
        private readonly SQLServerDbContext _contexto;

    }//injeção de dependência do contexto do banco de dados 
}
