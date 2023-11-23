using Microsoft.EntityFrameworkCore;
using Nsc.Models;

namespace Nsc.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }

        public DbSet<Cadastro>? Cadastros { get; set; }
        public DbSet<Reserva>? Reservas { get; set; }
        public DbSet<Pagamento>? Pagamentos { get; set; }




    }
}
