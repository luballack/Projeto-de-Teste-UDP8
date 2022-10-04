using Microsoft.EntityFrameworkCore;
using teste_upd8.Models.Domain;

namespace teste_upd8.Data
{
    public class UPD8DbContext : DbContext
    {
        public UPD8DbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
