using Microsoft.EntityFrameworkCore;
using Teste_Tecnico_SmartHint.Models;

namespace Teste_Tecnico_SmartHint.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        { }

        public DbSet<Customers> Customers { get; set; }
    }
}
