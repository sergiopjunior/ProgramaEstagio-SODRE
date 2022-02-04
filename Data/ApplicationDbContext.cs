using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgramaEstagio.Models.Entidades;

namespace ProgramaEstagio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Sale> Sale { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sale>().HasOne(p => p.UserForeignKey).WithMany(b => b.Sales).HasForeignKey(p => p.UserID);
            builder.Entity<Sale>().Property(obj => obj.SaleValue).HasPrecision(18, 4);

            base.OnModelCreating(builder);
        }
    }
}
