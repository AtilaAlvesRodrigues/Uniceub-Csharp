using MBGestaoEscolarAN.Entities;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Data
{
    public class SQLServerDbContext : DbContext
    {
        public SQLServerDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
