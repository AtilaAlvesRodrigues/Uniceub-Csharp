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


        public async Task<int> AdicionarAsync(Coordenador coordeenador)
        { 
            _contexto.Coordernadores.Add(coordeenador);
            await _contexto.SaveChangesAsync();
            return coordeenador.CoordenadorId; 
        }

        public async Task<bool> AlterarAsync(Coordenador coordenador)
        {
            var coordenadorExistente = await _contexto.Coordernadores
                .FindAsync(coordenador.CoordenadorId);
            if (coordenadorExistente == null)
            {
                return false;
            }            
            _contexto.Entry(coordenadorExistente).CurrentValues.SetValues(coordenador);
            return await _contexto.SaveChangesAsync() > 0; // Retorna true se a alteração foi bem-sucedida
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var coordenador = await _contexto.Coordernadores.FindAsync(id);
            if (coordenador == null)
            {
                return false;
            }
            _contexto.Coordernadores.Remove(coordenador);
            return await _contexto.SaveChangesAsync() > 0; // Retorna
        }

        public async Task<Coordenador?> ListarPorIdAsync(int id)
        {
            return await _contexto.Coordernadores
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CoordenadorId == id);
        }

        public async Task<IEnumerable<Coordenador>> ListarTodosAsync()
        {
            return await _contexto.Coordernadores
                .AsNoTracking()
                .OrderBy(x => x.CoordenadorId)
                .ToListAsync();
        }



    }
}
