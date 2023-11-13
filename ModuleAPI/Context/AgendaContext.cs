using Microsoft.EntityFrameworkCore;
using ModuleAPI.Entities;

namespace ModuleAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        } 

        public DbSet<Contato> Contatos { get; set; } 
    }
}
