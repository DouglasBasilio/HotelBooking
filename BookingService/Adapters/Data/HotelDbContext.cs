using Microsoft.EntityFrameworkCore;
using Entities = Domain.Entities;

namespace Data
{
    public class HotelDbContext : DbContext
    {
        // injetando a parte de conexão com banco de dados
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public virtual DbSet<Entities.Guest> Guests { get; set; }
    }
}