using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class AlunoService:IAlunoService
    {
        private readonly SQLServerDbContext _contexto;
        //injeção de dependência do contexto do banco de dados 
        public AlunoService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Aluno aluno)
        {
            if (aluno.DataCadastro == default)
            {
                aluno.DataCadastro = DateTime.Now;
            }
            _contexto.Alunos.Add(aluno);
            await _contexto.SaveChangesAsync();
            return aluno.AlunoId; // Retorna o ID do aluno adicionado
        }

        public async Task<bool> AlterarAsync(Aluno aluno)
        {
            var alunoExistente = await _contexto.Alunos
                .FindAsync(aluno.AlunoId);
            if(alunoExistente == null)
            {
                return false;
            }
            aluno.DataCadastro = DateTime.Now; // Atualiza a data de cadastro
            _contexto.Entry(alunoExistente).CurrentValues.SetValues(aluno);
            return await _contexto.SaveChangesAsync() > 0; // Retorna true se a alteração foi bem-sucedida
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var aluno = await _contexto.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return false;
            }
            _contexto.Alunos.Remove(aluno);
            return await _contexto.SaveChangesAsync() > 0; // Retorna true se a exclusão foi bem-sucedida
        }

        public async Task<Aluno?> ListarPorIdAsync(int id)
        {
            return await _contexto.Alunos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.AlunoId == id);
        }

        public async Task<IEnumerable<Aluno>> ListarTodosAsync()
        {
            return await _contexto.Alunos
                .AsNoTracking()
                .OrderBy(x => x.Nome)
                .ToListAsync();
        }
    }
}