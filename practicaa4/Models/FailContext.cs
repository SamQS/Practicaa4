using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace practicaa4.Models
{
    public class FailContext : IdentityDbContext
    {
         public FailContext(DbContextOptions dco) : base(dco) {

        }
        public DbSet<Fotos> Foto { get; set; }
        public DbSet<Comentario> Comenta { get; set; }

    }
}