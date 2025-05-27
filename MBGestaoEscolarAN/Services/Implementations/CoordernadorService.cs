using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CoordernadorService : ICoordernadorService
    {
        private readonly SQLServerDbContext _contexto;
        public CoordernadorService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

      
    }
}
